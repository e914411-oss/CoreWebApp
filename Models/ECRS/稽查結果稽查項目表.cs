using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 稽查結果稽查項目表
{
    /// <summary>
    /// 稽查項目序號
    /// </summary>
    public int 稽查項目序號 { get; set; }

    /// <summary>
    /// 稽查項目中文名稱
    /// </summary>
    public string 稽查項目中文名稱 { get; set; } = null!;

    /// <summary>
    /// 稽查項目英文名稱
    /// </summary>
    public string 稽查項目英文名稱 { get; set; } = null!;

    /// <summary>
    /// 稽查項目大類中文
    /// </summary>
    public string 稽查項目大類中文 { get; set; } = null!;

    /// <summary>
    /// 稽查項目大類英文
    /// </summary>
    public string 稽查項目大類英文 { get; set; } = null!;

    /// <summary>
    /// 各稽查儲存對應表名
    /// </summary>
    public string 各稽查儲存對應表名 { get; set; } = null!;

    /// <summary>
    /// 各稽查儲存對應pk欄位名稱
    /// </summary>
    public string 各稽查儲存對應pk欄位名稱 { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }

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
