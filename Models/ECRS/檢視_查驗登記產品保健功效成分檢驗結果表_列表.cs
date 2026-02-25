using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品保健功效成分檢驗結果表_列表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 保健功效成分 { get; set; }

    public string? 檢測值 { get; set; }

    public string? 標示值 { get; set; }

    public string? 合格與否 { get; set; }

    public string? 產品類型代碼 { get; set; }
}
