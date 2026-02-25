using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處行政處分_罰鍰_債權憑證
{
    public int 主鍵 { get; set; }

    public int 罰鍰主表主鍵 { get; set; }

    public DateOnly? 取得日期 { get; set; }

    public string? 文號 { get; set; }
}
