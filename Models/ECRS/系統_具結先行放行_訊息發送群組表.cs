using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_具結先行放行_訊息發送群組表
{
    public int 主鍵 { get; set; }

    public string? 發送帳號 { get; set; }

    public string? 送至帳號 { get; set; }

    public DateTime 建立時間 { get; set; }
}
