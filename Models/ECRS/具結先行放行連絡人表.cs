using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行連絡人表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 報驗案號
    /// </summary>
    public string? 報驗案號 { get; set; }

    public decimal? 運往地點序號 { get; set; }

    public string? 連絡人 { get; set; }

    public string? 連絡人電話 { get; set; }

    public string? 連絡人行動電話 { get; set; }

    public string? 連絡人傳真機號碼 { get; set; }

    public string? 連絡人email { get; set; }

    public string? 備註 { get; set; }

    public string? IFI系統PK { get; set; }
}
