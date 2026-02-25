using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒速報發佈時間
{
    public int 主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public int? 第幾次速報 { get; set; }

    public DateTime? 速報時間 { get; set; }
}
