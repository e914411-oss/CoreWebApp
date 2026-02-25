using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_醫療器材結案稽查主檔
{
    public int 主鍵 { get; set; }

    public int? 總稽查件數 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 稽查縣市主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public DateTime? 稽查日期 { get; set; }
}
