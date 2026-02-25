using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 產品責任保險稽查主表_紀錄
{
    public int 完成主鍵 { get; set; }

    public string? 異動原因 { get; set; }

    public string? 紀錄人員 { get; set; }

    public int 主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public DateOnly? 保險期間_起 { get; set; }

    public DateOnly? 保險期間_迄 { get; set; }

    public string? 國曆保險期間_起 { get; set; }

    public string? 國曆保險期間_迄 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 備註說明 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 結案日期_國曆 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動日期_國曆 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 稽查日期_國曆 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 違反食品安全衛生管理法第十三條 { get; set; }
}
