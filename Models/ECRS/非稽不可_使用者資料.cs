using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_使用者資料
{
    public string 身分證號 { get; set; } = null!;

    public string? 姓名 { get; set; }

    public string? 所屬單位機關代碼 { get; set; }

    public string? 所屬單位名稱 { get; set; }

    public string? 所屬單位縣市代碼 { get; set; }

    public string? 所屬科別 { get; set; }
}
