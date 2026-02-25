using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using CoreWebApp.Services;

namespace CoreWebApp.Controllers
{
    public class EntryController : Controller
    {
        private string _LoginUrl = string.Empty;
        private readonly AuthApiClient _authApi;
        private readonly GspOAuthClient _gsp;



        public EntryController(AuthApiClient authApi, GspOAuthClient gsp)
        {
            _authApi = authApi;
            _gsp = gsp;
        }

        public IActionResult Index()
        {
            // 將資料帶到 View
            ViewBag.Message = @"
這裡放三個登入方式，由左至右分別為：
1、帳號密碼（點擊後導入Login頁面）
2、實體自然人憑證（點擊後導到自然人憑證登入頁面，帳密驗證成功後回傳相關信息回來再導到稽查首頁。）
3、行動自然人憑證（點擊後導到自然人憑證登入頁面，帳密驗證成功後回傳相關信息回來再導到稽查首頁。）";
            return View();
        }

        //E政府帳號登入驗證
        [HttpPost]
        public IActionResult LoginB()
        {
            //_LoginUrl = "https://www.cp.gov.tw/portal/Clogin.aspx?ReturnUrl=https://gsp.fda.gov.tw/oAuth/?code=pmds&ver=Simple&Level=1";

            var state = Guid.NewGuid().ToString("N");
            HttpContext.Session.SetString("EgovLoginBState", state);

            // cp 登入成功後回到你系統
            var myCallback = Url.Action(
                action: "LoginBCallback",
                controller: "Entry",
                values: new { state },
                protocol: Request.Scheme
            );

            var loginUrl = "https://www.cp.gov.tw/portal/Clogin.aspx"
            + "?ver=Simple"
            + "&Level=1"
            + "&ReturnUrl=" + Uri.EscapeDataString(myCallback);

            return Redirect(loginUrl);

        }

        //自然人憑證登入驗證
        [HttpPost]
        public IActionResult LoginC()
        {
            _LoginUrl = "";
            return View();
        }

        //醫事憑證登入驗證
        [HttpPost]
        public IActionResult LoginD()
        {
            _LoginUrl = "";
            return View();
        }



        // 這個 action 是「你系統的 callback」
        // 外部成功後，你要讓它回到：/Entry/LoginBCallback?code=...&ver=...&Level=...
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LoginBCallback(string state, CancellationToken ct)
        {
            //var expected = HttpContext.Session.GetString("LoginB_State");
            //if (string.IsNullOrWhiteSpace(state) || expected != state)
            //    return Unauthorized("Invalid state");

            // gsp 發 token / code 後，回到你系統這個 endpoint
            var myOauthCallback = Url.Action(
                action: "LoginBOAuthCallback",
                controller: "Entry",
                values: new { state },
                protocol: Request.Scheme
            );

            // 指定固定要打這支
            var gspUrl =
                "https://gsp.fda.gov.tw/oAuth/"
                + "?code=pmds"
                + "&ver=Simple"
                + "&Level=1"
                // ★這個參數名要以 gsp 規格為準：可能叫 ReturnUrl / redirect_uri / callback...
                + "&ReturnUrl=" + Uri.EscapeDataString(myOauthCallback);

            return Redirect(gspUrl);

        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LoginBOAuthCallback(string state, string token, string access_token, string code)
        {

            // 1) 原始整串 QueryString（含 ?）
            var rawQs = HttpContext.Request.QueryString.Value; // 例如 "?state=...&code=..."

            // 2) 解析後的 Query (key/value)
            var queryDict = HttpContext.Request.Query.ToDictionary(k => k.Key, v => v.Value.ToString());

            // 3) 你也可以直接看完整被呼叫的 URL（含 scheme/host/path/query）
            var fullUrl = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";


            var expected = HttpContext.Session.GetString("LoginB_State");
            if (string.IsNullOrWhiteSpace(state) || expected != state)
                return Unauthorized("Invalid state");

            // (A) 如果 gsp 直接回 token
            var finalToken = token ?? access_token;

            if (!string.IsNullOrWhiteSpace(finalToken))
            {
                // TODO: 這裡做你系統的登入簽發（cookie/jwt），並保存 token
                // e.g. HttpContext.Session.SetString("GSP_Token", finalToken);

                return RedirectToAction("Index", "Home");
            }

            // (B) 如果 gsp 回傳的是 code（授權碼），你就要用 HttpClient 換 token
            if (!string.IsNullOrWhiteSpace(code))
            {
                // TODO: 依 gsp 規格呼叫 token endpoint 換 token（這段需要 gsp 文件）
                // var tokenResp = await _httpClient.PostAsync(...)

                return RedirectToAction("Index", "Home");
            }

            return BadRequest("No token/code returned from GSP.");
        }


    }




    //// POST: /Hello/Greet
    //[HttpPost]
    //public IActionResult Greet(string name)
    //{
    //    // 這裡示範最簡單的表單接收（先不用 ViewModel）
    //    if (string.IsNullOrWhiteSpace(name))
    //    {
    //        ViewBag.Result = "你沒有輸入名字。";
    //    }
    //    else
    //    {
    //        ViewBag.Result = $"你好，{name}！歡迎進入 ASP.NET Core MVC。";
    //    }

    //    // 重用同一個 View 顯示結果
    //    ViewBag.Message = "這是我的第一個 MVC 網頁（.NET 8）";
    //    return View("Index");
    //}
}

