using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品衛生標準檢驗結果表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-監測種類
    /// </summary>
    public string? 監測種類 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-監測項目
    /// </summary>
    public string? 監測項目 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-檢測值
    /// </summary>
    public string? 檢測值 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-法規標準
    /// </summary>
    public string? 法規標準 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-合格與否
    /// </summary>
    public string? 合格與否 { get; set; }

    public string? 產品類型代碼 { get; set; }

    /// <summary>
    /// 衛生標準檢驗-合格與否
    /// </summary>
    public DateTime? 異動日期 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public virtual 查驗登記產品查核明細表? 查驗登記產品查核明細表主鍵Navigation { get; set; }
}
