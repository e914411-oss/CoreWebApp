using Microsoft.AspNetCore.Http;

namespace CoreWebApp.Services
{
    public interface IDeviceDetector
    {
        bool IsMobile(HttpContext http);
    }

    public sealed class DeviceDetector : IDeviceDetector
    {
        // 常見行動裝置 UA 關鍵字（保守但夠用；你可再加）
        private static readonly string[] MobileTokens = new[]
        {
            "Android", "webOS", "iPhone", "iPad", "iPod",
            "BlackBerry", "Windows Phone", "Opera Mini", "IEMobile",
            "Mobile", "Tablet"
        };

        public bool IsMobile(HttpContext http)
        {
            // 1) 優先用 Client Hints（若瀏覽器/反向代理有送）
            // Sec-CH-UA-Mobile: ?1 表示 mobile
            if (http.Request.Headers.TryGetValue("Sec-CH-UA-Mobile", out var chMobile))
            {
                if (chMobile.ToString().Contains("?1"))
                    return true;
            }

            // 2) 回退：User-Agent 判斷
            var ua = http.Request.Headers.UserAgent.ToString();
            if (string.IsNullOrWhiteSpace(ua))
                return false;

            return MobileTokens.Any(t => ua.Contains(t, StringComparison.OrdinalIgnoreCase));
        }
    }
}