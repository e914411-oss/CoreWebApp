using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業別次分類表
{
    public string 主鍵 { get; set; } = null!;

    public string? 業別次分類名稱 { get; set; }

    public string 業別主分類主鍵 { get; set; } = null!;

    public string? 停用註記 { get; set; }

    public int 流水編號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
