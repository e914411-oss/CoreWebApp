using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 來源文件保存稽查_主表
{
    public int 主鍵 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 限期改善日期_國曆 { get; set; }

    public string? 以書面或電子化保存來源文件 { get; set; }

    public string? 載明收貨日期或批號 { get; set; }

    public string? 載明材料或成品之資訊 { get; set; }

    public string? 載明供應商資訊 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 承辦_備註說明 { get; set; }

    public string? 承辦意見 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 違反法條_食安第九條第一項 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 衛生局系統主鍵 { get; set; }

    public string? 第一次衛生局系統主鍵 { get; set; }

    public string? 前一次衛生局系統主鍵 { get; set; }
}
