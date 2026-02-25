using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專門職業或技術證照人員查核_主表
{
    public int 主鍵 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 聘用食品專職或技術證照人員 { get; set; }

    public string? 登錄各該人員資料及衛生講習或訓練時數 { get; set; }

    public string? 不適用原因_無工廠登記 { get; set; }

    public string? 不適用原因_資本額未達3千萬 { get; set; }

    public string? 不適用原因_食品從業人員未滿20人 { get; set; }

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

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 違反法條_食安第十二條 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 衛生局系統主鍵 { get; set; }

    public string? 不適用原因_非規範業別 { get; set; }
}
