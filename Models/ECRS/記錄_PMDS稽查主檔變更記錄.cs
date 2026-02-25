using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS稽查主檔變更記錄
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    public int? 稽查主檔識別碼 { get; set; }

    /// <summary>
    /// 縣市代碼檔
    /// </summary>
    public string? 縣市代碼 { get; set; }

    /// <summary>
    /// 業者編號
    /// </summary>
    public int? 業者主鍵 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 異動時間 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 異動原因 { get; set; }
}
