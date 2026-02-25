using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_查驗登記產品_查核項目
{
    public int 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 查驗登記產品類型代碼 { get; set; }

    public string? 合格與否1 { get; set; }

    public string? 合格與否2 { get; set; }

    public string? 合格與否3 { get; set; }

    public string? 合格與否4 { get; set; }
}
