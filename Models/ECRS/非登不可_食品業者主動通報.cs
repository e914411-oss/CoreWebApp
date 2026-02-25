using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非登不可_食品業者主動通報
{
    public int 系統編號 { get; set; }

    public int? 通報案件編號 { get; set; }

    public string? 公司登錄字號 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 產品來源 { get; set; }

    public string? 產品類型 { get; set; }

    public string? 製造廠商名稱 { get; set; }

    public string? 供應廠商名稱 { get; set; }

    public string? 不符合原因 { get; set; }

    public DateOnly? 業者通報日期 { get; set; }

    public string? 數量_單位 { get; set; }

    public DateOnly? 進口日期 { get; set; }

    public DateOnly? 製造日期 { get; set; }

    public DateOnly? 有效日期 { get; set; }

    public double? 總淨重_公斤 { get; set; }

    public string? 產品批號 { get; set; }

    public DateTime? PMDS匯入時間 { get; set; }

    public string? PMDS縣市編號 { get; set; }

    public string? PMDS案件狀態 { get; set; }
}
