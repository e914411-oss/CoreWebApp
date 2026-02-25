using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒攝食場所明細表
{
    public int? 食品中毒速報主表主鍵 { get; set; }

    public int 食品中毒攝食場所明細表_主鍵 { get; set; }

    public string? 攝食場所名稱 { get; set; }

    public string? 食品供應商 { get; set; }

    public string? 食品供應商地址 { get; set; }

    public string? 攝食地點_地址 { get; set; }

    public string? 攝食場所類別 { get; set; }

    public string? 攝食日期民國日 { get; set; }
}
