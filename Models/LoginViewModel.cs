using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "請輸入帳號")]
        [Display(Name = "帳號")]
        public string UserName { get; set; } = default!;

        [Required(ErrorMessage = "請輸入密碼")]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; } = default!;

        public string? ErrorMessage { get; set; }

        // 登入成功後要導回的頁
        public string? ReturnUrl { get; set; }

        public bool? RememberMe { get; set; } = false;
    }
}
