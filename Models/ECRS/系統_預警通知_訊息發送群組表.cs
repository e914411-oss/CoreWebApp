using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_訊息發送群組表
{
    /// <summary>
    /// 群組Id
    /// </summary>
    public int 群組表主鍵 { get; set; }

    /// <summary>
    /// 建立人員部門
    /// </summary>
    public string? 縣市代碼 { get; set; }

    /// <summary>
    /// 群組名稱
    /// </summary>
    public string? 群組名稱 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 建立者帳號 { get; set; }

    public string? 更新者帳號 { get; set; }

    public string? 類型 { get; set; }
}
