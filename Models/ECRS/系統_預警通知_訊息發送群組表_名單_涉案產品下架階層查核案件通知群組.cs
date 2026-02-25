using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_訊息發送群組表_名單_涉案產品下架階層查核案件通知群組
{
    public int 主鍵 { get; set; }

    public int? 群組表主鍵 { get; set; }

    public string? 名單人員 { get; set; }

    public string? 電子信箱 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 建立者帳號 { get; set; }

    public string? 更新者帳號 { get; set; }
}
