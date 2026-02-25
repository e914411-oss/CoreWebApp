using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_pmds_samp_item
{
    public string dohno { get; set; } = null!;

    public int sampid { get; set; }

    public string? 申請衛生局 { get; set; }

    public string? 檢驗衛生局 { get; set; }

    public string? 狀態 { get; set; }

    public string 檢驗類別 { get; set; } = null!;

    public string 檢驗項目 { get; set; } = null!;

    public string 檢驗成分 { get; set; } = null!;

    public string 分析方法 { get; set; } = null!;

    public string 檢驗員 { get; set; } = null!;

    public string? 數據 { get; set; }

    public string? 單位 { get; set; }

    public string? 檢驗判定 { get; set; }

    public string? 完成日期 { get; set; }

    public string 類別編號 { get; set; } = null!;

    public string 項目編號 { get; set; } = null!;

    public string 成分編號 { get; set; } = null!;

    public string 方法編號 { get; set; } = null!;
}
