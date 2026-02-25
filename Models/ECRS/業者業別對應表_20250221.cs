using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者業別對應表_20250221
{
    public int 主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? 業別次分類主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
