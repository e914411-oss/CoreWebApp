using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品違反法條表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public int? 查驗登記產品法條主鍵 { get; set; }

    public string? 法條內容 { get; set; }
}
