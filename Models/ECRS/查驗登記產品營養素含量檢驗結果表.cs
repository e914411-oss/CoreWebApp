using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品營養素含量檢驗結果表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-監測項目
    /// </summary>
    public string? 監測項目 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-檢測值
    /// </summary>
    public string? 檢測值 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-標示值
    /// </summary>
    public string? 標示值 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-合格與否
    /// </summary>
    public string? 合格與否 { get; set; }

    public int? 排序 { get; set; }

    public string? 產品類型代碼 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-監測類別
    /// </summary>
    public string? 監測類別代碼 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-產品每日最高建議食用量
    /// </summary>
    public string? 產品每日最高建議食用量 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-維生素每日實際攝取量
    /// </summary>
    public string? 維生素每日實際攝取量 { get; set; }

    /// <summary>
    /// 營養素含量檢驗-維生素每日食用限量標準
    /// </summary>
    public string? 維生素每日食用限量標準 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public virtual 查驗登記產品查核明細表? 查驗登記產品查核明細表主鍵Navigation { get; set; }
}
