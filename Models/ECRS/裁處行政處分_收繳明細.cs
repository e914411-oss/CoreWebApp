using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處行政處分_收繳明細
{
    public int 主鍵 { get; set; }

    public int 罰鍰主表主鍵 { get; set; }

    public int 行政處分類別 { get; set; }

    public int? 繳納期數 { get; set; }

    public DateOnly? 收據開立日期 { get; set; }

    public string? 收據編號 { get; set; }

    public int? 繳納金額 { get; set; }
}
