using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者稽查主檔
{
    public int 化粧品業者稽查主檔ID { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 縣市代碼檔 { get; set; }

    public string? 工作紀錄內容 { get; set; }

    public int? 稽查結果ID { get; set; }

    public DateTime? 限期改正日期 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 處分情形_行政處分 { get; set; }

    public string? 處分情形_停業 { get; set; }

    public DateOnly? 處分情形_停業期限 { get; set; }

    public string? 處分情形_歇業 { get; set; }

    public string? 處分情形_廢止其登記 { get; set; }

    public string? 處分情形_移送法辦 { get; set; }

    public string? 處分情形_其它 { get; set; }

    public string? 處分情形_其它原因 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 前一次衛生局主鍵 { get; set; }

    public string? 最初衛生局主鍵 { get; set; }

    public int? 前一次業者稽查主檔ID { get; set; }

    public int? 第一次業者稽查主檔ID { get; set; }
}
