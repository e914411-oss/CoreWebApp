using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_待複查清單
{
    public string? 稽查項目 { get; set; }

    public string? 複查日期 { get; set; }

    public string 營業縣市 { get; set; } = null!;

    public string? 市招名稱 { get; set; }

    public string? 營業地址 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 案件處理人員 { get; set; }

    public int 稽查ID { get; set; }
}
