using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品藥品醫療器材標示稽查次類別表
{
    public int 主鍵 { get; set; }

    public string? 標示稽查次類別內容 { get; set; }

    public int? 標示稽查主類別主鍵 { get; set; }

    public int? 排序 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
