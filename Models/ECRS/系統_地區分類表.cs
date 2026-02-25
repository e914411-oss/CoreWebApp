using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_地區分類表
{
    /// <summary>
    /// 區別ID
    /// </summary>
    public int 區域別 { get; set; }

    /// <summary>
    /// 分區名稱
    /// </summary>
    public string? 地區名稱 { get; set; }

    /// <summary>
    /// 父層項目
    /// </summary>
    public int? 父層編號 { get; set; }

    /// <summary>
    /// 是否為縣市 1 是  0:否
    /// </summary>
    public int? 是否縣市 { get; set; }

    /// <summary>
    /// 縣市代碼
    /// </summary>
    public string? 縣市編號 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public string? 建立時間 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員 { get; set; }

    public string? 階層 { get; set; }
}
