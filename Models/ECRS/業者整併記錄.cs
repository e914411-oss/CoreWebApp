using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者整併記錄
{
    public int 主鍵 { get; set; }

    public string? 單位主鍵 { get; set; }

    public string? 使用者主鍵 { get; set; }

    public DateTime? 整併時間 { get; set; }

    public string? 主業者 { get; set; }

    public string? 被併業者 { get; set; }

    public string? 被併業別 { get; set; }
}
