using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_代碼_明細表
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 明細表編號 { get; set; }

    /// <summary>
    /// 代碼主類別
    /// </summary>
    public int? 系統代碼主表編號 { get; set; }

    /// <summary>
    /// 代碼值
    /// </summary>
    public string? 代碼值 { get; set; }

    /// <summary>
    /// 代碼名稱
    /// </summary>
    public string? 代碼名稱 { get; set; }

    /// <summary>
    /// 代碼描述
    /// </summary>
    public string? 代碼描述 { get; set; }

    /// <summary>
    /// 顯示順序
    /// </summary>
    public int? 顯示順序 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立人員員編
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 最後修改員編
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 異動人員 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }
}
