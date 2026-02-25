using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class VW_刑責回報逾半年未結案資料
{
    public string? 稽查類別 { get; set; }

    public int? 稽查案件類別 { get; set; }

    public string? 縣市代碼 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public DateTime? 結案日期 { get; set; }
}
