using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核主表紀錄
{
    public int 完成主鍵 { get; set; }

    /// <summary>
    /// 修改原因
    /// </summary>
    public string 異動原因 { get; set; } = null!;

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime 記錄日期 { get; set; }

    public string 紀錄人員 { get; set; } = null!;

    /// <summary>
    /// 登錄查核主檔ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 稽查主檔ID
    /// </summary>
    public int 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 業者為經公告須登錄之類別_但尚未完成登錄
    /// </summary>
    public string? 業者為經公告須登錄之類別但尚未完成登錄 { get; set; }

    /// <summary>
    /// 查核對象
    /// </summary>
    public string? 查核對象 { get; set; }

    /// <summary>
    /// 稽查結果代碼
    /// </summary>
    public string? 稽查結果代碼 { get; set; }

    /// <summary>
    /// 稽查結果
    /// </summary>
    public string? 稽查結果 { get; set; }

    /// <summary>
    /// 限期改善
    /// </summary>
    public string? 限期改善日期_國曆 { get; set; }

    /// <summary>
    /// 其他
    /// </summary>
    public string? 稽查結果_其他說明 { get; set; }

    /// <summary>
    /// 現場稽查結果
    /// </summary>
    public string? 現場稽查結果說明 { get; set; }

    /// <summary>
    /// 食品衛生管理法第八條第三項
    /// </summary>
    public string? 違反法條_食品衛生管理法第八條第三項 { get; set; }

    /// <summary>
    /// 歇業
    /// </summary>
    public string? 處理情形_歇業 { get; set; }

    /// <summary>
    /// 停業
    /// </summary>
    public string? 處理情形_停業 { get; set; }

    /// <summary>
    /// 廢止營業或工廠登記
    /// </summary>
    public string? 處理情形_廢止營業或工廠登記 { get; set; }

    /// <summary>
    /// 廢止登錄
    /// </summary>
    public string? 處理情形_廢止登錄 { get; set; }

    /// <summary>
    /// 罰鍰金額
    /// </summary>
    public decimal? 處理情形_罰鍰金額 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string? 備註說明 { get; set; }

    /// <summary>
    /// 稽查員ID
    /// </summary>
    public string? 稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦員ID
    /// </summary>
    public string? 承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審查員ID
    /// </summary>
    public string? 審查人員主鍵 { get; set; }

    /// <summary>
    /// 前一次稽(複)查編號
    /// </summary>
    public int 前一次稽查主鍵 { get; set; }

    /// <summary>
    /// 複查筆數(第n筆)
    /// </summary>
    public int? 複查筆數 { get; set; }

    /// <summary>
    /// 最初稽查事件編號
    /// </summary>
    public int? 最初稽查主鍵 { get; set; }

    /// <summary>
    /// 案件狀態
    /// </summary>
    public string? 作業階段 { get; set; }

    /// <summary>
    /// 案件執行人員
    /// </summary>
    public string? 作業負責人員主鍵 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public string? 國曆結案日期 { get; set; }

    /// <summary>
    /// 結案狀態
    /// </summary>
    public string? 結案狀態 { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 修改人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }

    /// <summary>
    /// 查核日期
    /// </summary>
    public DateTime? 查核稽查日期 { get; set; }

    /// <summary>
    /// 登錄字號
    /// </summary>
    public string? 食品業者登錄字號 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateOnly? 建立日期 { get; set; }

    public string? 業者非強制食品業者登錄對象 { get; set; }
}
