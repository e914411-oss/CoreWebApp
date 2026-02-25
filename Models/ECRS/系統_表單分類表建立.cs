using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_表單分類表建立
{
    /// <summary>
    /// PK
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 目錄Id
    /// </summary>
    public int 表單分類檔主鍵 { get; set; }

    /// <summary>
    /// 表單Id
    /// </summary>
    public int 表單主鍵 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
