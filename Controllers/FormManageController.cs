using CoreWebApp.Models;
using CoreWebApp.Services;
using CoreWebApp.Models.ECRS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;

namespace CoreWebApp.Controllers
{
    [Authorize]
    public class FormManageController : Controller
    {
        private readonly ReadDTApiClient _api;
        private readonly ILogger<FormManageController> _logger;

        public FormManageController(ReadDTApiClient api, ILogger<FormManageController> logger)
        {
            _api = api;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // ...組 model，可忽略
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("Index" /*, model */);

            return View(/* model */);
        }

        public async Task<IActionResult> FormQryByPJ()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("FormQryByPJ");

            return View();
        }

        public async Task<IActionResult> FormEditer(string cities)
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                var DeptDt = await Get_系統_部門表(string.Empty);
                ViewBag.DeptList = DeptDt;
                return PartialView("FormEditer");
            }

            return View();
        }

        //[HttpGet]
        public async Task<IActionResult> FormAdd()
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("FormAdd");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormAdd(string FormName)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                ViewData["FormName"] = string.IsNullOrEmpty(FormName) ? string.Empty : FormName;
                return PartialView("FormAdd");
            }

            return View();
        }





        public async Task<List<系統_部門表>> Get_系統_部門表(string cities)
        {
            var deptDt = await _api.Query_系統_部門表(cities);

            try
            {
                return await _api.Query_系統_部門表(cities);
            }
            catch (Exception ex)
            {
                throw;
            }

            return deptDt;
        }


    }
}
