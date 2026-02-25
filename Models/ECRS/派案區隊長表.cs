using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案區隊長表
{
    public int 派案區隊長表主鍵 { get; set; }

    public int? 派案縣市表主鍵 { get; set; }

    public string? 派案區 { get; set; }

    public int? 目標數 { get; set; }

    public string? 是否分派 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
