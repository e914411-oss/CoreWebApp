using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案稽查人員業者表
{
    public int 派案稽查人員業者表主鍵 { get; set; }

    public string? 派案來源 { get; set; }

    public int? 派案稽查人員主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 是否綁定業者 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public int? 稽查事件主鍵 { get; set; }
}
