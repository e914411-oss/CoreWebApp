using System.Net;
using System.Net.Http.Json;
using CoreWebApp.Models;

namespace CoreWebApp.Services
{
    public class AuthApiClient
    {
        private readonly HttpClient _http;

        public AuthApiClient(HttpClient http)
        {
            _http = http;
        }

        
        //從外部網站登入後接Token回來做驗證用
        public async Task<EgovUserInfo?> VerifyEgovTokenAsync(string token)
        {
            var resp = await _http.PostAsJsonAsync("/auth/egov/verify", new { token });
            if (!resp.IsSuccessStatusCode) return null;
            return await resp.Content.ReadFromJsonAsync<EgovUserInfo>();
        }


        //用戶帳號密碼登入用
        public async Task<LoginResponse> LoginAsync(LoginRequest req, CancellationToken ct = default)
        {
            // API 路由：POST /api/Auth/Login（對應 CoreAPI）
            var resp = await _http.PostAsJsonAsync("/Api/Auth/Login", req, ct);
            var raw = await resp.Content.ReadAsStringAsync(ct);

            //if (!resp.IsSuccessStatusCode)
            //{
            //    // 你可以先用這行直接看 raw 是什麼
            //    throw new Exception($"API {(int)resp.StatusCode} {resp.ReasonPhrase}: {raw}");
            //}


            // API 在 401 也會回 JSON（LoginResponse），這裡盡量讀回訊息
            LoginResponse? body = null;
            try
            {
                body = await resp.Content.ReadFromJsonAsync<LoginResponse>(cancellationToken: ct);
            }
            catch
            {
                // ignore JSON parse errors
                return new LoginResponse
                {
                    Success = false,
                    Message = body?.Message ?? $"API error: {(int)resp.StatusCode} {resp.ReasonPhrase}"
                };
            }

            return body;

            //if (resp.IsSuccessStatusCode && body != null)
            //    return body;

            //if (resp.StatusCode == HttpStatusCode.Unauthorized && body != null)
            //    return body;

            //return new LoginResponse
            //{
            //    Success = false,
            //    Message = body?.Message ?? $"API error: {(int)resp.StatusCode} {resp.ReasonPhrase}"
            //};
        }
    }


    public class EgovUserInfo
    {
        public string UserId { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public string[] Roles { get; set; } = Array.Empty<string>();
    }


}
