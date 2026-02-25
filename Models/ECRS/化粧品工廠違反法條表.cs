using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品工廠違反法條表
{
    /// <summary>
    /// 工廠檢查條文不合格記錄ID
    /// </summary>
    public int 化粧品工廠違反法條表主鍵 { get; set; }

    /// <summary>
    /// 化粧品工廠稽查主檔ID
    /// </summary>
    public int? 化粧品工廠稽查主表主鍵 { get; set; }

    /// <summary>
    /// 工廠檢查條文ID
    /// </summary>
    public int? 檢查法條主鍵 { get; set; }

    /// <summary>
    /// 條文類別
    /// </summary>
    public string? 條文類別 { get; set; }

    public string? 條文註解 { get; set; }

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
