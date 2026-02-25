using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輸入產品查核管理_下游業者清單
{
    public int 編號 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 非登字號 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 電子信箱 { get; set; }

    public string? 地址 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 數量 { get; set; }

    public string? 批號 { get; set; }

    public string? 國別 { get; set; }

    public string? 是否已轉入 { get; set; }

    public int? 來源稽查編號 { get; set; }

    public int? 來源物品明細編號 { get; set; }

    public DateTime? 上傳日期 { get; set; }

    public string? 出貨日期 { get; set; }

    public string? 必查註記 { get; set; }
}
