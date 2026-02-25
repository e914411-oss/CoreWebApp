using Microsoft.Extensions.Options;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;


namespace CoreWebApp
{
    public class GspOAuthClient
    {
        private readonly HttpClient _http;
        private readonly GovLoginOptions _opt;


        public GspOAuthClient(HttpClient http, IOptions<GovLoginOptions> opt)
        {
            _http = http;
            _opt = opt.Value;
        }

        public Task<string?> GetTokenFromConfigAsync(CancellationToken ct = default)
        {
            if (string.IsNullOrWhiteSpace(_opt.Code) || string.IsNullOrWhiteSpace(_opt.Ver))
                throw new InvalidOperationException("GovLogin1:Code / Ver 未設定");

            return GetTokenAsync(_opt.Code, _opt.Ver, _opt.Level, ct);
        }

        public async Task<string?> GetTokenAsync(string code, string ver, int level, CancellationToken ct = default)
        {
            if (string.IsNullOrWhiteSpace(code)) throw new ArgumentException("code is required", nameof(code));
            if (string.IsNullOrWhiteSpace(ver)) throw new ArgumentException("ver is required", nameof(ver));

            var url = $"/oAuth/?code={Uri.EscapeDataString(code)}&ver={Uri.EscapeDataString(ver)}&Level={level}";
            // ...照你原本邏輯繼續解析 redirect / body 抓 token
            // return token;
            return null;
        }

    }
}
