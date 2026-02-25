using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 真空包裝工廠稽查主表
{
    public int 主鍵 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十二條第一項第九款
    /// </summary>
    public string 違反法條_食品安全衛生管理法第二十二條第一項第九款 { get; set; } = null!;

    /// <summary>
    /// 食品安全衛生管理法第八條第一項
    /// </summary>
    public string 違反法條_食品安全衛生管理法第八條第一項 { get; set; } = null!;

    /// <summary>
    /// 停業
    /// </summary>
    public string 處理情形_停業 { get; set; } = null!;

    /// <summary>
    /// 移送法院
    /// </summary>
    public string 處理情形_移送法院 { get; set; } = null!;

    /// <summary>
    /// 罰鍰金額
    /// </summary>
    public int 處理情形_罰鍰金額 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string 備註 { get; set; } = null!;

    public string 作業階段 { get; set; } = null!;

    public string? 作業負責人員主鍵 { get; set; }

    public string 稽查人員主鍵 { get; set; } = null!;

    public string 承辦人員主鍵 { get; set; } = null!;

    public string 審查人員主鍵 { get; set; } = null!;

    public DateTime? 結案日期_國曆 { get; set; }

    public string 結案狀態 { get; set; } = null!;

    public string 複查註記 { get; set; } = null!;

    public int 前一次稽查主鍵 { get; set; }

    public int 複查筆數 { get; set; }

    public int 最初稽查主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 作業單位 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 處理情形_行政處分 { get; set; }
}
