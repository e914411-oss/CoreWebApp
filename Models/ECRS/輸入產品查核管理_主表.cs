using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輸入產品查核管理_主表
{
    public int 主表編號 { get; set; }

    public int? 稽查編號 { get; set; }

    public string? 廠商名稱 { get; set; }

    public int? 於PMDS上業者編號 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 非登字號 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 電子信箱 { get; set; }

    public string? 縣市 { get; set; }

    public string? 營登地址街道 { get; set; }

    public string? 是否為製造業 { get; set; }

    public string? 是否為販售業 { get; set; }

    public string? 是否為餐飲業 { get; set; }

    public string? 是否為輸入業 { get; set; }

    public string? 稽查狀態 { get; set; }

    public string? 不稽查原因 { get; set; }

    public string? 不稽查原因_備註 { get; set; }

    public DateTime? 資料轉入日期 { get; set; }

    public string? 進口日期 { get; set; }

    public string? 已通知衛生局 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? IMF0001_ID { get; set; }

    public DateTime? 通知衛生局時間 { get; set; }

    public DateTime? 決定稽查時間 { get; set; }

    public string? 必查註記 { get; set; }
}
