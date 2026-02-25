using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品標示稽查表
{
    /// <summary>
    /// 標示稽查記錄ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 藥品稽查序號
    /// </summary>
    public int? 藥品稽查明細表主鍵 { get; set; }

    /// <summary>
    /// 藥品稽查序號標示稽查主類別ID
    /// </summary>
    public int? 標示稽查主類別主鍵 { get; set; }

    /// <summary>
    /// 標示稽查次類別ID
    /// </summary>
    public int? 標示稽查次類別主鍵 { get; set; }

    public string? 標示稽查結果 { get; set; }

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
