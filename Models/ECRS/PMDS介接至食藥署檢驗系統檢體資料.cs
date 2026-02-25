using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class PMDS介接至食藥署檢驗系統檢體資料
{
    public string? 送驗單號 { get; set; }

    public int? 案件編號 { get; set; }

    public string? 案件類別 { get; set; }

    public int 檢體編號 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 檢驗類別 { get; set; }

    public string? 檢驗項目 { get; set; }

    public string? 檢驗成分 { get; set; }

    public string? 檢驗類別中文名稱 { get; set; }

    public string? 檢驗項目中文名稱 { get; set; }

    public string? 檢驗成分中文名稱 { get; set; }

    public string? 抽樣_攝食_地點 { get; set; }

    public string? 抽樣_攝食_地址 { get; set; }

    public string? 製造廠商名稱 { get; set; }

    public string? 製造廠商地址 { get; set; }

    public string? 供應廠商名稱 { get; set; }

    public string? 供應廠商地址 { get; set; }

    public string? 抽樣目的 { get; set; }
}
