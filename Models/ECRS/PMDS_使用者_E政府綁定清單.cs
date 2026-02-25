using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class PMDS_使用者_E政府綁定清單
{
    public int 主鍵 { get; set; }

    public string 帳號 { get; set; } = null!;

    public string 姓名 { get; set; } = null!;

    public DateTime? 綁定時間 { get; set; }

    public int 綁定方式_代碼 { get; set; }

    public string 綁定方式_內容 { get; set; } = null!;

    public string? EMAIL { get; set; }

    public string? 身分證字號 { get; set; }

    public string 綁定TOKEN值 { get; set; } = null!;

    public string? 人員別 { get; set; }

    public string? 安全等級 { get; set; }

    public string? ISMS_使用者帳號 { get; set; }

    public string? ISMS_姓名 { get; set; }
}
