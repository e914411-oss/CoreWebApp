using CoreWebApp.Models;
using CoreWebApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;


namespace CoreWebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthApiClient _api;

        public AuthController(AuthApiClient api)
        {
            _api = api;
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new LoginViewModel());
        }



        [HttpGet]
        public IActionResult Denied()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel vm, string? returnUrl = null, CancellationToken ct = default)
        {
            ViewBag.ReturnUrl = returnUrl;

            if (!ModelState.IsValid)
                return View(vm);

            var apiResp = await _api.LoginAsync(new LoginRequest
            {
                UserId = vm.UserName,
                Password = vm.Password

            }, ct);

            if (!apiResp.Success || string.IsNullOrWhiteSpace(apiResp.Token))
            {
                ModelState.AddModelError(string.Empty, apiResp.Message);
                return View(vm);
            }

            // 1) 把 token 存在 Session（示範；若你想完全用 Cookie，也可改成把 Token 加密後存 Cookie）
            HttpContext.Session.SetString("AuthToken", apiResp.Token);
            var displayName = apiResp.User?.DisplayName ?? apiResp.User?.UserName ?? vm.UserName;
            HttpContext.Session.SetString("DisplayName", displayName);

            // 2) 建立 Cookie 驗證票證（對應 Program.cs 的 AddAuthentication("AppCookie")）
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, apiResp.User?.UserName ?? vm.UserName),
                new Claim(ClaimTypes.Name, displayName),
                new Claim("access_token", apiResp.Token) // 需要時可從 Claim 取得
            };

            var identity = new ClaimsIdentity(claims, "AppCookie");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                scheme: "AppCookie",
                principal: principal,
                properties: new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1)
                });

            // 3) 用 TempData 帶一次性訊息，給首頁顯示「登入成功」遮罩
            TempData["LoginSuccess"] = "登入成功";

            // 4) 導頁：優先 returnUrl（避免 open redirect 可做白名單檢查）
            //if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
            //    return Redirect(returnUrl);

            ViewBag.loginTime = DateTime.Now.ToString("yyyy/MM/DD HH:mm:ss");

            return RedirectToAction("Index", "Inspection");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("AppCookie");
            HttpContext.Session.Remove("AuthToken");
            HttpContext.Session.Remove("DisplayName");
            TempData["LoginSuccess"] = null;
            return RedirectToAction("Index", "Entry");
        }
    }
}

