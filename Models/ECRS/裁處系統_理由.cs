using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處系統_理由
{
    public int 主鍵 { get; set; }

    public int 裁處系統主表編號 { get; set; }

    public int 行政處分類別 { get; set; }

    public string? 內容 { get; set; }
}
