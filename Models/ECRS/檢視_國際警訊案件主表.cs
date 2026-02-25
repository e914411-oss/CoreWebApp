using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_國際警訊案件主表
{
    public int 系統編號 { get; set; }

    public string? 國際警訊案件編號 { get; set; }

    public string? 來源網站名稱 { get; set; }

    public DateTime? 來源網站發布日期 { get; set; }

    public string? 原文標題 { get; set; }

    public string? 回收警訊網址 { get; set; }

    public string? 產品生產國 { get; set; }

    public string? 業者統一編號 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者地址_縣市 { get; set; }

    public string? 業者地址_區域街道 { get; set; }

    public string? 業者完整地址 { get; set; }

    public string? 業者電話 { get; set; }

    public string? 業者傳真 { get; set; }

    public string? 國外產品名稱 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 回收原因 { get; set; }

    public DateTime? PMDS匯入時間 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? PMDS縣市編號 { get; set; }

    public string? PMDS案件狀態 { get; set; }

    public string? PMDS退回原因 { get; set; }

    public string? 是否為應回收項目 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 稽查日期民國 { get; set; }

    public string? 稽查時間_時 { get; set; }

    public string? 稽查時間_分 { get; set; }

    public string? 處辦情形_銷毀 { get; set; }

    public string? 處辦情形_銷毀日期 { get; set; }

    public double? 處辦情形_銷毀總重 { get; set; }

    public string? 處辦情形_退運 { get; set; }

    public string? 處辦情形_退運日期 { get; set; }

    public double? 處辦情形_退運總重 { get; set; }

    public string? 處辦情形_行政處分 { get; set; }

    public string? 處辦情形_其它 { get; set; }

    public string? 處辦情形_其它內容 { get; set; }

    public string? 來源網站發布日期民國 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 稽查人員 { get; set; }
}
