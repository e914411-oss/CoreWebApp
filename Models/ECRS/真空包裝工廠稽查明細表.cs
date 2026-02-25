using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 真空包裝工廠稽查明細表
{
    public int 主鍵 { get; set; }

    public int 真空包裝工廠稽查主檔主鍵 { get; set; }

    /// <summary>
    /// 產品名稱
    /// </summary>
    public string 產品名稱 { get; set; } = null!;

    /// <summary>
    /// 產品特性
    /// </summary>
    public string 產品特性 { get; set; } = null!;

    /// <summary>
    /// 產品特性(即食)
    /// </summary>
    public string 產品特性_即食 { get; set; } = null!;

    /// <summary>
    /// 產品特性(非即食)
    /// </summary>
    public string 產品特性_非即食 { get; set; } = null!;

    /// <summary>
    /// 水活性或pH值
    /// </summary>
    public string 水活性或pH值 { get; set; } = null!;

    /// <summary>
    /// 標示販售條件
    /// </summary>
    public string 標示販售條件 { get; set; } = null!;

    /// <summary>
    /// 商業滅菌
    /// </summary>
    public string 商業滅菌 { get; set; } = null!;

    /// <summary>
    /// 柵欄技術
    /// </summary>
    public string 柵欄技術 { get; set; } = null!;

    /// <summary>
    /// 標示保存期限
    /// </summary>
    public string 標示保存期限 { get; set; } = null!;

    /// <summary>
    /// 是否標示「須冷藏」或「須冷凍」
    /// </summary>
    public string 標示須冷藏或須冷凍 { get; set; } = null!;

    /// <summary>
    /// 字體長寬是否大於1CM
    /// </summary>
    public string 字體長寬大於1CM { get; set; } = null!;

    /// <summary>
    /// 是否符合GHP
    /// </summary>
    public string 符合GHP { get; set; } = null!;

    /// <summary>
    /// 稽查結果
    /// </summary>
    public string 稽查結果 { get; set; } = null!;

    /// <summary>
    /// 限期改善日期
    /// </summary>
    public string 限期改善日期_國曆 { get; set; } = null!;

    /// <summary>
    /// 應該善項目
    /// </summary>
    public string 應改善項目 { get; set; } = null!;

    /// <summary>
    /// 應該善項目(其他備註)
    /// </summary>
    public string 應改善項目_其他備註 { get; set; } = null!;

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string 是否送待複查 { get; set; } = null!;

    public string? 限期改善日期_供表單使用 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 處理情形_行政處分 { get; set; }
}
