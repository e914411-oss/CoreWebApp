using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 國際警訊_國際警訊案件主檔
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

    public string? 業者電話 { get; set; }

    public string? 業者傳真 { get; set; }

    public string? 國外產品名稱 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 回收原因 { get; set; }

    public DateTime? PMDS匯入時間 { get; set; }

    public string? PMDS縣市編號 { get; set; }

    public string? PMDS案件狀態 { get; set; }

    public string? PMDS退回原因 { get; set; }
}
