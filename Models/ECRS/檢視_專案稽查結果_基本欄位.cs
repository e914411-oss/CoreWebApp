using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_專案稽查結果_基本欄位
{
    public string? 稽查項目 { get; set; }

    public string? 稽查代號 { get; set; }

    public int 稽查編號 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public int? 業者代號 { get; set; }

    public int? 複查ID { get; set; }

    public string? 專案代號 { get; set; }

    public string 是否結案 { get; set; } = null!;

    public DateTime? 稽查日期時間 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string 營業地址 { get; set; } = null!;

    public string? 負責人 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 非登字號 { get; set; }

    public string? 統一編號 { get; set; }

    public string 稽查方式 { get; set; } = null!;
}
