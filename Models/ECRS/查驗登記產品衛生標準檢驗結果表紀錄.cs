using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品衛生標準檢驗結果表紀錄
{
    public int 紀錄主鍵 { get; set; }

    public int? 完成查驗登記產品查核明細表主鍵 { get; set; }

    public int? 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    public string? 監測種類 { get; set; }

    public string? 監測項目 { get; set; }

    public string? 檢測值 { get; set; }

    public string? 法規標準 { get; set; }

    public string? 合格與否 { get; set; }

    public string? 產品類型代碼 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public int? 前次完成查驗登記產品查核明細表主鍵 { get; set; }
}
