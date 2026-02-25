using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品工廠稽查專案表
{
    /// <summary>
    /// 稽查專案記錄編號
    /// </summary>
    public int 化粧品工廠稽查專案表主鍵 { get; set; }

    /// <summary>
    /// 化粧品工廠稽查主檔編號
    /// </summary>
    public int? 化粧品工廠稽查主表主鍵 { get; set; }

    /// <summary>
    /// 專案
    /// </summary>
    public int? 專案名稱主鍵 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }
}
