using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化妝品工廠稽查法條表
{
    /// <summary>
    /// 工廠檢查條文ID
    /// </summary>
    public int 化妝品工廠稽查法條表主鍵 { get; set; }

    /// <summary>
    /// 條文類別
    /// </summary>
    public string? 稽查法條種類 { get; set; }

    public string? 標題描述 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? 查核項目_文字內容 { get; set; }

    /// <summary>
    /// 條文註解
    /// </summary>
    public string? 查核項目_結論 { get; set; }

    public int? Upid { get; set; }

    public string? 項目描述 { get; set; }

    /// <summary>
    /// 條文順序
    /// </summary>
    public int? 法條順序 { get; set; }

    public int? 排序 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }
}
