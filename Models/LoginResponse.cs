namespace CoreWebApp.Models
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = default!;

        public string? Token { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public UserInfo? User { get; set; }

        public class UserInfo
        {
            public string Id { get; set; } = default;
            public string UserName { get; set; } = default!;
            public string DisplayName { get; set; } = default!;
        }
    }

}
