using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案目標表
{
    public int 派案目標表主鍵 { get; set; }

    public int? 專案名稱代碼表主鍵 { get; set; }

    public string? 派案類型 { get; set; }

    public int? 派案目標數 { get; set; }

    public string? 派案目標縣市 { get; set; }

    public string? 派案建立縣市 { get; set; }

    public DateTime? 派案建立時間 { get; set; }
}
