using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處行政處分_罰鍰_行政訴訟明細
{
    public int 主鍵 { get; set; }

    public int 罰鍰主表主鍵 { get; set; }

    public int 行政處分類別 { get; set; }

    public DateOnly? 受理日期 { get; set; }

    public DateOnly? 決定日期 { get; set; }

    public string? 受理機關 { get; set; }

    public string? 決定書文號 { get; set; }

    public string? 訴願結果 { get; set; }

    public string? 訴願結果_其他 { get; set; }
}
