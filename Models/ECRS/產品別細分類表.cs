using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 產品別細分類表
{
    /// <summary>
    /// 產品細分類代碼
    /// </summary>
    public string 產品別細分類編號 { get; set; } = null!;

    /// <summary>
    /// 產品細分類名稱
    /// </summary>
    public string? 產品別細分類名稱 { get; set; }

    /// <summary>
    /// 產品主分類代碼
    /// </summary>
    public string 產品別主分類編號 { get; set; } = null!;

    /// <summary>
    /// 產品次分類代碼
    /// </summary>
    public string 產品別次分類編號 { get; set; } = null!;

    /// <summary>
    /// 停用註記
    /// </summary>
    public string? 停用註記 { get; set; }

    /// <summary>
    /// 流水編號
    /// </summary>
    public int 流水編號 { get; set; }

    /// <summary>
    /// 異動日期
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員編號 { get; set; }
}
