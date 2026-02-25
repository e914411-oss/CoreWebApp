using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案縣市業者表
{
    public int 派案縣市業者表主鍵 { get; set; }

    public int? 派案縣市表主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
