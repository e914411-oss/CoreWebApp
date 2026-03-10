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
            //// 璶ゼ祅碞穦砆 Cookie middleware 旧 /Account/Login
            //return View();

            // ...舱 model┛菠
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

        public async Task<IActionResult> Fquery()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Fquery");

            var DeptDt = await Get_╰参_场(string.Empty);//string.Empty
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

        public async Task<List<╰参_场>> Get_╰参_场(string cities)
        {
            //var deptDt = await _api.Query_╰参_场(cities);

            try
            {
                return await _api.Query_╰参_场(cities);
            }
            catch (Exception ex)
            {
                throw;
            }

            //return deptDt;
        }

        public async Task<List<PMDS_诀篶_郡カで皌>> GetAreaByCity(string cityId)
        {
            //var deptDt = await _api.Query_PMDS_诀篶_郡カで皌(cityId);

            try
            {
                return await _api.Query_PMDS_诀篶_郡カで皌(cityId);
            }
            catch (Exception ex)
            {
                throw;
            }

            //return deptDt;
        }

    }
}
