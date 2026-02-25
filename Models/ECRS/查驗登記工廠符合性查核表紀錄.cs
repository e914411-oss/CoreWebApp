using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記工廠符合性查核表紀錄
{
    public int 完成紀錄主鍵 { get; set; }

    public int? 完成主鍵 { get; set; }

    public int? 主鍵 { get; set; }

    public int? 查驗登記工廠查核主表主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public string? 符合性查核_品名 { get; set; }

    /// <summary>
    /// 符合性查核-配方
    /// </summary>
    public string? 符合性查核_配方 { get; set; }

    public string? 符合性查核_包裝規格 { get; set; }

    public string? 符合性查核_標示內容 { get; set; }

    public int? 查驗登記產品主鍵 { get; set; }

    public string? 符合性查核_查核產品 { get; set; }

    public string? 查驗登記工廠類型代碼 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public int? 前次完成查驗登記工廠查核主表主鍵 { get; set; }
}
