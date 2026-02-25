using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_部門代碼檔
{
    public string 部門代碼 { get; set; } = null!;

    public string? 部門名稱 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 所屬區域 { get; set; }

    public string? 是否停用 { get; set; }
}
