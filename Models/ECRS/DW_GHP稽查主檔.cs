using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class DW_GHP稽查主檔
{
    public int GHP稽查ID { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者市鄉鎮 { get; set; }

    public string? 業者地址 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者業別_主 { get; set; }

    public string? 業者業別_次 { get; set; }

    public string? 稽查結果 { get; set; }
}
