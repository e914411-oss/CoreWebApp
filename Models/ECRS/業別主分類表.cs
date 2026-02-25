using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業別主分類表
{
    /// <summary>
    /// 業別主分類代碼
    /// </summary>
    public string 主鍵 { get; set; } = null!;

    /// <summary>
    /// 業別主分類名稱
    /// </summary>
    public string? 業別主分類名稱 { get; set; }

    /// <summary>
    /// 停用註記
    /// </summary>
    public string? 停用註記 { get; set; }

    /// <summary>
    /// 業別類型
    /// </summary>
    public string? 業別類型 { get; set; }

    /// <summary>
    /// 流水編號
    /// </summary>
    public int 流水編號 { get; set; }

    /// <summary>
    /// 異動日期
    /// </summary>
    public DateTime? 異動日期 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }
}
