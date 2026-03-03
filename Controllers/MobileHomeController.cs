using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    [Authorize]
    public class MobileHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}