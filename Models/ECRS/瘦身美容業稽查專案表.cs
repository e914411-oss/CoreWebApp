using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 瘦身美容業稽查專案表
{
    public int 瘦身美容業稽查專案表主鍵 { get; set; }

    public int? 瘦身美容業稽查主表主鍵 { get; set; }

    public int? 專案資料檔主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
