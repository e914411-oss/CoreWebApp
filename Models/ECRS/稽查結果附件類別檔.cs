using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 稽查結果附件類別檔
{
    /// <summary>
    /// 附件類別編號
    /// </summary>
    public int 附件類別編號 { get; set; }

    /// <summary>
    /// 附件類別名稱
    /// </summary>
    public string 附件類別名稱 { get; set; } = null!;

    /// <summary>
    /// 是否啟用
    /// </summary>
    public bool 是否啟用 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }

    public int? 排序 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime 建立日期 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string 建立人員 { get; set; } = null!;

    /// <summary>
    /// 更新日期
    /// </summary>
    public DateTime? 更新日期 { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public string? 更新人員 { get; set; }
}
