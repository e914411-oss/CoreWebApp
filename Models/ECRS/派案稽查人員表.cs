using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案稽查人員表
{
    public int 派案稽查人員表主鍵 { get; set; }

    public string? 派案來源 { get; set; }

    public int? 派案來源主鍵 { get; set; }

    public int? 目標數 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 是否稽查 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
