using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規_參訪人次資料檔
{
    public int 流水號 { get; set; }

    public DateTime? 參訪時間 { get; set; }

    public string? IP位址 { get; set; }

    public string? 參訪位置 { get; set; }
}
