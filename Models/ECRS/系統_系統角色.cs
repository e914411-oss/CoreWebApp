using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_系統角色
{
    /// <summary>
    /// 角色識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 角色名稱
    /// </summary>
    public string? 名稱 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime 異動時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 最後修改日期
    /// </summary>
    public string? 更新人員主鍵 { get; set; }
}
