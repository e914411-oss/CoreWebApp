using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_系統角色節點相關
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 系統角色識別碼
    /// </summary>
    public int 人員主鍵 { get; set; }

    /// <summary>
    /// 系統功能識別碼
    /// </summary>
    public int 節點主鍵 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 最後修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 是否刪除
    /// </summary>
    public string? 已刪除 { get; set; }
}
