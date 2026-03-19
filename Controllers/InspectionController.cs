using CoreWebApp.Models;
using CoreWebApp.Models.ECRS;
using CoreWebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using static CoreWebApp.Controllers.InspectionController;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //public IActionResult InspectionForms()
        //{
        //    //return View();
        //    if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        //        return PartialView("InspectionForms");

        //    return View();
        //}

        public IActionResult InspectionForms(string? _IsCompleted, string? _FormName)
        {
            if (!string.IsNullOrEmpty(_IsCompleted) || !string.IsNullOrEmpty(_FormName))
            {
                TempData["IsCompleted"] = (_IsCompleted == "1");
                TempData["FormName"] = _FormName;

                return RedirectToAction(nameof(InspectionForms));
            }

            bool isCompleted = false;
            if (TempData["IsCompleted"] != null)
            {
                isCompleted = Convert.ToBoolean(TempData["IsCompleted"]);
            }

            ViewBag.IsCompletedForm = isCompleted;
            ViewBag.FormName = TempData["FormName"]?.ToString();

            return View();
        }

        public IActionResult InspectionFormContent()
        {
            //return View();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("InspectionFormContent");

            return View();
        }

        public async Task<IActionResult> Fquery(Supplier supplierQ, int page = 1)
        {
            ViewData.Clear();
            ModelState.Clear();
            
            //return View();
            Supplier supplierQ1 = new Supplier();
            supplierQ1.業者名稱 = supplierQ.業者名稱;

            var supplier = await Get_Supplier(supplierQ1);
            if (supplier.Count == 0)
            {
                //supplierQ1.業者名稱 = "百鮮";
                //supplier = await Get_Supplier(supplierQ1);
            }
            int pageSize = 10;

            int totalCount = supplier.Count;

            var data = supplier;
                        //.OrderBy(s => s.Id)
                        //.Skip((page - 1) * pageSize)
                        //.Take(pageSize);

            //ViewBag.CurrentPage = page;
            //ViewBag.TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var vm = new SupplierPageViewModel
            {
                Suppliers = data.ToList(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                TotalCount = totalCount
            };

            var DeptDt = await Get_系統_部門表(string.Empty);
            ViewBag.DeptList = DeptDt;

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                totalCount = supplier.Count;

                data = supplier;

                vm = new SupplierPageViewModel
                {
                    Suppliers = data.ToList(),
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                    TotalCount = totalCount
                };

                return PartialView("_FqueryPartial", vm);
                //    return RedirectToAction("Fquery", "Inspection", new
                //    {
                //        業者名稱 = supplierQ.業者名稱
                //    }); //
            }

            return View("Fquery", vm);
            //return View(supplier);

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

        public async Task<IActionResult> Flist(string companyId)
        {
            Supplier supplierQ1 = new Supplier();
            supplierQ1.業者編號 = companyId;

            var vmC = await Get_Company(supplierQ1);
            var vmR = await Get_CheckRec(companyId);
            var vm = new CompanyPageViewModel();
            vm.Company = vmC;
            vm.CheckRecs = vmR;

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                //return PartialView("Flist", vm);
                return RedirectToAction("Flist", "Inspection", companyId = companyId); //
            }
            return View("Flist", vm);
        }

        //ExportExcelF
        public async Task<IActionResult> ExportExcelF(Supplier supplierQ)
        {
            // ❗不要用分頁條件
            var suppliers = await Get_Supplier(supplierQ); ;

            var sb = new StringBuilder();

            sb.AppendLine("<table border='1'>");
            sb.AppendLine("<tr>");
            sb.AppendLine("<th>業者編號</th><th>業者名稱</th><th>統一編號</th><th>電話號碼</th><th>業者地址</th>");
            sb.AppendLine("</tr>");

            foreach (var s in suppliers)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine($"<td>{s.業者編號}</td>");
                sb.AppendLine($"<td>{s.業者名稱}</td>");
                sb.AppendLine($"<td>{s.統一編號}</td>");
                sb.AppendLine($"<td>{s.電話號碼}</td>");
                sb.AppendLine($"<td>{s.業者地址}</td>");
                sb.AppendLine("</tr>");
            }

            sb.AppendLine("</table>");

            return File(Encoding.UTF8.GetBytes(sb.ToString()),
                "application/vnd.ms-excel",
                "業者資料.xls");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<List<系統_部門表>> Get_系統_部門表(string cities)
        {
            try
            {
                return await _api.Query_系統_部門表(cities);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<PMDS_機構_縣市匹配>> GetAreaByCity(string cityId)
        {
            try
            {
                return await _api.Query_PMDS_機構_縣市匹配(cityId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<List<Supplier>> Get_Supplier(Supplier supplierQ)
        {
            try
            {
                return await _api.Query_Supplier(supplierQ);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<業者資料表> Get_Company(Supplier supplierQ)
        {
            try
            {
                return await _api.Query_業者資料表(supplierQ);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<CheckRec>> Get_CheckRec(string companyId)
        {
            try
            {
                return await _api.Query_稽查資料(companyId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public class Supplier
        {
            public int? Id { get; set; }
            public string? 業者編號 { get; set; }
            public string? 業者名稱 { get; set; }
            public string? 食品登錄字號 { get; set; }
            public string? 統一編號 { get; set; }
            public string? 電話號碼 { get; set; }
            public string? 業者地址 { get; set; }
            public DateTime? 案件建立日期 { get; set; }
        }

        public class SupplierPageViewModel
        {
            public List<Supplier> Suppliers { get; set; }

            public int CurrentPage { get; set; }

            public int TotalPages { get; set; }

            public int TotalCount { get; set; }
        }

        public class CompanyPageViewModel
        {
            public 業者資料表 Company { get; set; }
            public List<CheckRec> CheckRecs { get; set; }

        }

        public class CheckRec
        {
            public int? 稽查單號 { get; set; }
            public string? 稽查表單 { get; set; }
            public string? 稽查人員 { get; set; }
            public string? 稽查進度 { get; set; }
            public DateTime? 稽查日期 { get; set; }
            public string? 稽查結果 { get; set; }
            public string? 執行狀態 { get; set; }
        }

    }
}
