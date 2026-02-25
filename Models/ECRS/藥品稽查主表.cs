using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品稽查主表
{
    /// <summary>
    /// 藥品稽查主檔ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 稽查序號
    /// </summary>
    public int? 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 總稽查件數
    /// </summary>
    public int? 總稽查件數 { get; set; }

    /// <summary>
    /// 業者編號
    /// </summary>
    public int? 業者主鍵 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public DateOnly? 稽查日期 { get; set; }

    /// <summary>
    /// 稽查人員
    /// </summary>
    public string? 稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦人員
    /// </summary>
    public string? 承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審查人員
    /// </summary>
    public string? 審查人員主鍵 { get; set; }

    /// <summary>
    /// 流程階段
    /// </summary>
    public string? 作業階段 { get; set; }

    /// <summary>
    /// 結案狀態
    /// </summary>
    public string? 結案狀態 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public DateOnly? 結案日期 { get; set; }

    public string? 備註 { get; set; }

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

    public string? 衛生局主鍵 { get; set; }
}
