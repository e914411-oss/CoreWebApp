using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP稽查主表紀錄
{
    public int 完成主鍵 { get; set; }

    public string 異動原因 { get; set; } = null!;

    public DateTime 記錄日期 { get; set; }

    public string 紀錄人員 { get; set; } = null!;

    public int 主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? HACCP介接主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 國曆限期改善日期 { get; set; }

    public string? 違反法條_食品衛生管理法第八條第二項 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查事件編號 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 承辦備註 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
