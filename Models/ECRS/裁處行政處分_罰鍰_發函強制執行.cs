using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處行政處分_罰鍰_發函強制執行
{
    public int 主鍵 { get; set; }

    public int 罰鍰主表主鍵 { get; set; }

    public DateOnly? 執行日期 { get; set; }

    public string? 文號 { get; set; }

    public int 金額 { get; set; }
}
