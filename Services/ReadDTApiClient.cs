using CoreWebApp.Models;
using CoreWebApp.Models.ECRS;
using System.Net;
using System.Net.Http.Json;
using static CoreWebApp.Controllers.InspectionController;

namespace CoreWebApp.Services
{
    public class ReadDTApiClient
    {
        private readonly HttpClient _http;
        


        public ReadDTApiClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<系統_部門表>> Query_系統_部門表(string _cityies, CancellationToken ct = default)
        {
            var action = Uri.EscapeDataString("系統_部門表");
            var url = $"/Api/FormManage/{action}";

            var resp = await _http.PostAsJsonAsync(url, _cityies, ct);

            if (!resp.IsSuccessStatusCode)
            {
                var raw = await resp.Content.ReadAsStringAsync(ct);
                throw new Exception(
                    $"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}"
                );
            }

            var body = await resp.Content.ReadFromJsonAsync<List<系統_部門表>>(cancellationToken: ct);
            return body ?? new List<系統_部門表>();

        }


        public async Task<List<PMDS_機構_縣市匹配>> Query_PMDS_機構_縣市匹配(string _cityies, CancellationToken ct = default)
        {
            var action = Uri.EscapeDataString("PMDS_機構_縣市匹配");
            var url = $"/Api/FormManage/{action}";

            var resp = await _http.PostAsJsonAsync(url, _cityies, ct);

            if (!resp.IsSuccessStatusCode)
            {
                var raw = await resp.Content.ReadAsStringAsync(ct);
                throw new Exception(
                    $"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}"
                );
            }

            var body = await resp.Content.ReadFromJsonAsync<List<PMDS_機構_縣市匹配>>(cancellationToken: ct);
            return body ?? new List<PMDS_機構_縣市匹配>();

        }


        public async Task<List<Supplier>> Query_Supplier(Supplier supplierQ, CancellationToken ct = default)
        {
            var action = Uri.EscapeDataString("Suppliers");
            var url = $"/Api/FormManage/{action}";

            var resp = await _http.PostAsJsonAsync(url, supplierQ, ct);

            if (!resp.IsSuccessStatusCode)
            {
                var raw = await resp.Content.ReadAsStringAsync(ct);
                throw new Exception(
                    $"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}"
                );
            }

            var body = await resp.Content.ReadFromJsonAsync<List<Supplier>>(cancellationToken: ct);
            return body ?? new List<Supplier>();

        }

        //業者資料表
        public async Task<業者資料表> Query_業者資料表(Supplier supplierQ, CancellationToken ct = default)
        {
            var action = Uri.EscapeDataString("業者資料表");
            var url = $"/Api/FormManage/{action}";

            var resp = await _http.PostAsJsonAsync(url, supplierQ, ct);

            if (!resp.IsSuccessStatusCode)
            {
                var raw = await resp.Content.ReadAsStringAsync(ct);
                throw new Exception(
                    $"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}"
                );
            }

            var body = await resp.Content.ReadFromJsonAsync<業者資料表>(cancellationToken: ct);
            return body ?? new 業者資料表();

        }

        public async Task<List<CheckRec>> Query_稽查資料(string companyId, CancellationToken ct = default)
        {
            var action = Uri.EscapeDataString("稽查資料");
            var url = $"/Api/FormManage/{action}";

            var resp = await _http.PostAsJsonAsync(url, companyId, ct);

            if (!resp.IsSuccessStatusCode)
            {
                var raw = await resp.Content.ReadAsStringAsync(ct);
                throw new Exception(
                    $"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}"
                );
            }

            var body = await resp.Content.ReadFromJsonAsync<List<CheckRec>>(cancellationToken: ct);
            return body ?? new List<CheckRec>();

        }
    }
}
