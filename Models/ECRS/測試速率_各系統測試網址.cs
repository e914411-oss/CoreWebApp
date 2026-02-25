using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 測試速率_各系統測試網址
{
    public int 測試網址編號 { get; set; }

    public int? 系統編號 { get; set; }

    public string? 測試類型 { get; set; }

    public string? 服務網址 { get; set; }
}
