using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_收尋_明細_HACCP
{
    public string? 市招名稱 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 鄉鎮區名稱 { get; set; }

    public string? 營業地址_街道 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人姓名 { get; set; }

    public string? 匯出1 { get; set; }

    public string? 衛生專職人員 { get; set; }

    public string? 衛生管理人員 { get; set; }

    public string? 技師證號 { get; set; }

    public string? 食品技師姓名 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public int HACCP稽查主表主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? HACCP介接主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 國曆限期改善日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 承辦備註 { get; set; }

    public string? 違反法條_食品衛生管理法第八條第二項 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 匯出3 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 匯出2 { get; set; }

    public string? 業別分類主鍵 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 業者主鍵 { get; set; }

    public int? 最初稽查事件編號 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 次分類_主鍵 { get; set; }

    public string? 主分類_名稱 { get; set; }

    public string? 次分類_名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 承辦意見 { get; set; }

    public DateTime? 評定分級結果日期 { get; set; }

    public string? HACCP規範對象 { get; set; }

    public string? HACCP規範對象_說明 { get; set; }

    public string? 分級結果 { get; set; }

    public string? 備註說明 { get; set; }
}
