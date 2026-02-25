using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥商_藥局_醫療機構稽查專案表
{
    public int 藥商_藥局_醫療機構稽查專案主鍵 { get; set; }

    public int? 藥商_藥局_醫療機構稽查主表主鍵 { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
