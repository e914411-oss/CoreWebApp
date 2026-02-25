using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_使用者_角色相關
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 使用者代碼
    /// </summary>
    public string? 使用者ID { get; set; }

    /// <summary>
    /// 角色ID
    /// </summary>
    public int 角色主鍵 { get; set; }

    public string? 申請來源 { get; set; }

    public string? 是否移除 { get; set; }

    public string? 權限 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立者 { get; set; }

    /// <summary>
    /// 最後修改時間
    /// </summary>
    public DateTime? 更新異動時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 更新者 { get; set; }
}
