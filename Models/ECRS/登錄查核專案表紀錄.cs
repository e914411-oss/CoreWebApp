using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核專案表紀錄
{
    public int 完成主鍵 { get; set; }

    public int 完成登錄查核主檔主鍵 { get; set; }

    public DateTime 記錄日期 { get; set; }

    /// <summary>
    /// 稽查專案記錄編號
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 化粧品工廠稽查主檔編號
    /// </summary>
    public int? 登錄查核主檔主鍵 { get; set; }

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
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }
}
