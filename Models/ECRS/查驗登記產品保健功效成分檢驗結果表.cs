using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品保健功效成分檢驗結果表
{
    public int 主鍵 { get; set; }

    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    /// <summary>
    /// 保健功效成份檢驗-保健功效成分
    /// </summary>
    public string? 保健功效成分 { get; set; }

    /// <summary>
    /// 保健功效成份檢驗-檢測值
    /// </summary>
    public string? 檢測值 { get; set; }

    /// <summary>
    /// 保健功效成份檢驗-標示值
    /// </summary>
    public string? 標示值 { get; set; }

    /// <summary>
    /// 保健功效成份檢驗-合格與否
    /// </summary>
    public string? 合格與否 { get; set; }

    public string? 產品類型代碼 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public virtual 查驗登記產品查核明細表? 查驗登記產品查核明細表主鍵Navigation { get; set; }
}
