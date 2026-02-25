using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 簽名檔案資料記錄
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 簽名檔編號 { get; set; }

    /// <summary>
    /// 稽查事件ID
    /// </summary>
    public int 稽查主檔編號 { get; set; }

    /// <summary>
    /// 簽名類別 M:稽查人員  C:會辦人員 T:受稽查人員
    /// </summary>
    public string? 簽名檔類型 { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    public string? 簽名檔檔名 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
