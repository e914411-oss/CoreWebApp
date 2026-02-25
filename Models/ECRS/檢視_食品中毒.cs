using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 案由 { get; set; }

    public string? 通報單位 { get; set; }

    public string? 國曆通報日期 { get; set; }

    public DateTime? 通報日期時間 { get; set; }
}
