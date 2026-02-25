using System.Net;
using System.Net.Http.Json;
using CoreWebApp.Models;
using CoreWebApp.Models.ECRS;

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

    }
}
