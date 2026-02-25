using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者登錄字號對應表
{
    public int 主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
