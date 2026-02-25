using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核主表
{
    public int 主鍵 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    public string? 業者為經公告須登錄之類別但尚未完成登錄 { get; set; }

    public string? 查核對象 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 限期改善日期_國曆 { get; set; }

    public string? 稽查結果_其他說明 { get; set; }

    public string? 現場稽查結果說明 { get; set; }

    public string? 違反法條_食品衛生管理法第八條第三項 { get; set; }

    public string? 處理情形_歇業 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_廢止營業或工廠登記 { get; set; }

    public string? 處理情形_廢止登錄 { get; set; }

    public decimal? 處理情形_罰鍰金額 { get; set; }

    public string? 備註說明 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public int 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 查核稽查日期 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 第一次衛生局主鍵 { get; set; }

    public string? 前次衛生局主鍵 { get; set; }

    public byte[]? 工作紀錄檔 { get; set; }

    public string? 業者非強制食品業者登錄對象 { get; set; }
}
