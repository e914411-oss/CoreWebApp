using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP稽查業別表
{
    public int 系統編號 { get; set; }

    public int GHP稽查主鍵 { get; set; }

    public string? 稽查主業別主鍵 { get; set; }

    public string? 稽查次業別主鍵 { get; set; }

    public DateTime? 建立日期 { get; set; }
}
