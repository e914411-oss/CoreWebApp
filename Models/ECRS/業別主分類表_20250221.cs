using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業別主分類表_20250221
{
    public string 主鍵 { get; set; } = null!;

    public string? 業別主分類名稱 { get; set; }

    public string? 停用註記 { get; set; }

    public string? 業別類型 { get; set; }

    public int 流水編號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
