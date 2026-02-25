using CoreWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreWebApp.Controllers
{
    [Authorize]
    public class InspectionController : Controller
    {
        private readonly ILogger<InspectionController> _logger;

        public InspectionController(ILogger<InspectionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //// 只要未登入，就會被 Cookie middleware 導向 /Account/Login
            //return View();

            // ...組 model，可忽略
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Index" /*, model */);

            return View(/* model */);
        }

        public IActionResult InspectionQry()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("InspectionQry");

            return View();
        }

        public IActionResult Fquery()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Fquery");

            return View();
        }

        public IActionResult FormQuery()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("FormQuery");

            return View();
        }

        public IActionResult ReviewPerform()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("ReviewPerform");
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
