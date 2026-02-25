using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 報表檔案資料記錄
{
    public int 報表檔編號 { get; set; }

    /// <summary>
    /// 稽查事件檔
    /// </summary>
    public int? 稽查主檔編號 { get; set; }

    /// <summary>
    /// 報表類別
    /// </summary>
    public string? 報表檔類型 { get; set; }

    /// <summary>
    /// 報表檔案名稱
    /// </summary>
    public string? 報表檔檔名 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
