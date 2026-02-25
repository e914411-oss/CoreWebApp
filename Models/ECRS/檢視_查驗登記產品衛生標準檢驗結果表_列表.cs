using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品衛生標準檢驗結果表_列表
{
    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public int 主鍵 { get; set; }

    public string? 監測種類 { get; set; }

    public string? 監測項目 { get; set; }

    public string? 合格與否 { get; set; }

    public string? 法規標準 { get; set; }

    public string? 檢測值 { get; set; }

    public string? 產品類型代碼 { get; set; }
}
