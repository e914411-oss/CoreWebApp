using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案縣市表
{
    public int 派案縣市表主鍵 { get; set; }

    public int? 專案名稱代碼表主鍵 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 是否分派 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
