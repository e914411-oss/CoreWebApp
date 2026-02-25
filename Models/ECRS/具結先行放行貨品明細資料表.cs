using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行貨品明細資料表
{
    public int 主鍵 { get; set; }

    public decimal? 貨品明細序號 { get; set; }

    public double? 內裝數量 { get; set; }

    public decimal? 運往地點序號 { get; set; }

    public string? 報驗案號 { get; set; }
}
