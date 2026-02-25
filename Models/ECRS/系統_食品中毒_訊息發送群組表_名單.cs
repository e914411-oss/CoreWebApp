using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_食品中毒_訊息發送群組表_名單
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 群組Id
    /// </summary>
    public int? 群組表主鍵 { get; set; }

    /// <summary>
    /// 群組成員帳號
    /// </summary>
    public string? 名單人員 { get; set; }

    public string? 建立時間 { get; set; }

    public string? 更新時間 { get; set; }

    public string? 建立者帳號 { get; set; }

    public string? 更新者帳號 { get; set; }
}
