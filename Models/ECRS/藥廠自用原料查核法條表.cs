using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥廠自用原料查核法條表
{
    /// <summary>
    /// 違反法條ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 違反法條內容
    /// </summary>
    public string? 違反法條內容 { get; set; }

    /// <summary>
    /// 條文註解
    /// </summary>
    public string? 條文註解 { get; set; }

    /// <summary>
    /// 法條順序
    /// </summary>
    public int? 法條順序 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立日期 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動日期 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }
}
