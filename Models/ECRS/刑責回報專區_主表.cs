using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_主表
{
    public int 主鍵 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public int? 稽查案件類別 { get; set; }

    public int? 各稽查類別編號 { get; set; }

    public string? 會同單位 { get; set; }

    public int? 案件狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 結案人員 { get; set; }
}
