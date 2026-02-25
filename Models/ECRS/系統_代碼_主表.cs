using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_代碼_主表
{
    /// <summary>
    /// 代碼識別碼
    /// </summary>
    public int 主表編號 { get; set; }

    /// <summary>
    /// 代碼名稱
    /// </summary>
    public string? 代碼名稱 { get; set; }

    /// <summary>
    /// 代碼說明
    /// </summary>
    public string? 代碼說明 { get; set; }

    /// <summary>
    /// 是否可維護
    /// </summary>
    public string? 是否可維護 { get; set; }

    /// <summary>
    /// 建立人員員編
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 最後修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 異動人員 { get; set; }
}
