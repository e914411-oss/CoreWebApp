using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 用藥安全新聞通報附件表
{
    /// <summary>
    /// 新聞檔案ID
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 用藥安全新聞通報ID
    /// </summary>
    public int? 用藥安全新聞通報主表_主鍵 { get; set; }

    /// <summary>
    /// 檔名 (含延伸名)
    /// </summary>
    public string? 檔案名稱 { get; set; }

    public string? 檔案類型 { get; set; }

    public long? 檔案大小 { get; set; }

    /// <summary>
    /// 檔案實體
    /// </summary>
    public byte[]? 檔案實體 { get; set; }

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
