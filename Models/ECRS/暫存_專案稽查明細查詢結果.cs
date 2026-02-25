using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 暫存_專案稽查明細查詢結果
{
    public int 系統編號 { get; set; }

    public int? 申請單編號 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 稽查項目 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者鄉鎮 { get; set; }

    public string? 業者地址 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 結案日期 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string? 稽查項目編號 { get; set; }

    public DateTime? 建立時間 { get; set; }
}
