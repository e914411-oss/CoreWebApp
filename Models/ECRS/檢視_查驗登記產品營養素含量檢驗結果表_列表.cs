using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_查驗登記產品營養素含量檢驗結果表_列表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 監測項目 { get; set; }

    public string? 檢測值 { get; set; }

    public string? 標示值 { get; set; }

    public string? 合格與否 { get; set; }

    public int? 排序 { get; set; }

    public string? 維生素每日食用限量標準 { get; set; }

    public string? 維生素每日實際攝取量 { get; set; }

    public string? 產品每日最高建議食用量 { get; set; }

    public string? 監測類別代碼 { get; set; }

    public string? 產品類型代碼 { get; set; }
}
