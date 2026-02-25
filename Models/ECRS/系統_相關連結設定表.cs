using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_相關連結設定表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 連結名稱
    /// </summary>
    public string? 連結名稱 { get; set; }

    /// <summary>
    /// 連結網址
    /// </summary>
    public string? 連結網址 { get; set; }

    /// <summary>
    /// 連結開啟方式
    /// </summary>
    public string? 連結開啟方式 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    public int? 排序 { get; set; }
}
