using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ISMS;

public partial class ISMS_查詢登入資訊
{
    public string 系統代碼 { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime 登入時間 { get; set; }

    public DateTime? 登出時間 { get; set; }

    public string? 來源ip { get; set; }

    public string? Uid { get; set; }

    public string? CAType { get; set; }

    public string? 帳號 { get; set; }

    public string? 名稱 { get; set; }

    public string? 綁定憑證 { get; set; }

    public string? Mail { get; set; }

    public string? 手機 { get; set; }

    public string? 單位oid { get; set; }

    public string? 人員別 { get; set; }

    public string? 安全等級 { get; set; }

    public string? 區別名稱 { get; set; }

    public string? 單位名稱 { get; set; }
}
