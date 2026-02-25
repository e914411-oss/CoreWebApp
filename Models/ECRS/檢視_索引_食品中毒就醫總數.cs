using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒就醫總數
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 主要案件編號 { get; set; }

    public DateTime? 就醫日期 { get; set; }
}
