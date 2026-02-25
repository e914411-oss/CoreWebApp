using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 產品責任保險稽查_規模種類表
{
    public int 主鍵 { get; set; }

    public int 產品責任保險稽查主表_主鍵 { get; set; }

    public string 有商業或公司登記 { get; set; } = null!;

    public string 有工廠登記 { get; set; } = null!;

    public string 有稅籍登記 { get; set; } = null!;

    public string 有農產品初級加工場 { get; set; } = null!;

    public string 其他 { get; set; } = null!;

    public string? 其他_內容 { get; set; }
}
