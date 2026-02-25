using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 縣市是否新增待複查檔
{
    /// <summary>
    /// Pk:流水號
    /// </summary>
    public int 系統編號 { get; set; }

    /// <summary>
    /// FK:AP_Dept.DptCode
    /// </summary>
    public string? 單位代碼 { get; set; }

    public string? GHP稽查 { get; set; }

    public string? HACCP稽查 { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 標示稽查 { get; set; }

    public string? 熟食稽查 { get; set; }

    public string? 油炸油稽查 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 追溯追蹤稽查 { get; set; }

    public string? 一級品管稽查 { get; set; }

    public string? 真空包裝稽查 { get; set; }

    public string? 查驗登記工廠稽查 { get; set; }

    public string? 查驗登記產品蹤稽查 { get; set; }

    public string? 化粧品_抽驗稽查 { get; set; }

    public string? 化粧品_標示稽查 { get; set; }

    public string? 藥品_抽驗稽查 { get; set; }

    public string? 藥品_標示稽查 { get; set; }

    public string? 醫療器材_抽驗稽查 { get; set; }

    public string? 醫療器材_標示稽查 { get; set; }

    public string? 藥商_藥局_醫療機構_其他稽查 { get; set; }

    public string? 瘦身美容業稽查 { get; set; }

    public string? 化粧品工廠稽查 { get; set; }

    public string? 藥廠自用原料稽查 { get; set; }

    public string? 通路藥品回收稽查 { get; set; }

    public string? 化粧品業者稽查 { get; set; }

    public string? 化粧品_產品登錄稽查 { get; set; }

    public string? 化粧品_產品資訊檔案稽查 { get; set; }
}
