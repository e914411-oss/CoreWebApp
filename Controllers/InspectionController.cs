using CoreWebApp.Models;
using CoreWebApp.Services;
using CoreWebApp.Models.ECRS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreWebApp.Controllers
{
    [Authorize]
    public class InspectionController : Controller
    {
        private readonly ReadDTApiClient _api;
        private readonly ILogger<InspectionController> _logger;

        public InspectionController(ReadDTApiClient api, ILogger<InspectionController> logger)
        {
            _api = api;
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

        public IActionResult InspectionForms()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("InspectionForms");

            return View();
        }

        public IActionResult InspectionFormContent()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("InspectionFormContent");

            return View();
        }

        public IActionResult Fquery()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Fquery");

            var DeptDt = await Get_系統_部門表(string.Empty);//string.Empty
            ViewBag.DeptList = DeptDt;
            return View();
        }

        public IActionResult FormQuery()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("FormQuery");

            return View();
        }

        public IActionResult FormContent()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("FormContent");

            return View();
        }

        public IActionResult PReview()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("PReview");

            return View();
        }

        public IActionResult ReviewPerform()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("ReviewPerform");
            return View();
        }

        public IActionResult Flist()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Flist");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<List<系統_部門表>> Get_系統_部門表(string cities)
        {
            //var deptDt = await _api.Query_系統_部門表(cities);

            try
            {
                return await _api.Query_系統_部門表(cities);
            }
            catch (Exception ex)
            {
                throw;
            }

            //return deptDt;
        }

        public async Task<List<PMDS_機構_縣市匹配>> GetAreaByCity(string cityId)
        {
            //var deptDt = await _api.Query_PMDS_機構_縣市匹配(cityId);

            try
            {
                return await _api.Query_PMDS_機構_縣市匹配(cityId);
            }
            catch (Exception ex)
            {
                throw;
            }

            //return deptDt;
        }

    }
}
