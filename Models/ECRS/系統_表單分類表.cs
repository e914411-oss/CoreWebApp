using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_表單分類表
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 父層Id
    /// </summary>
    public int? 父層主鍵 { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    public string? 分類名稱 { get; set; }

    /// <summary>
    /// 使用者帳號
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    public string? 階層 { get; set; }
}
