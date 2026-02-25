using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 焦點快訊_附件表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 最新消ID
    /// </summary>
    public int 焦點快訊主鍵 { get; set; }

    /// <summary>
    /// 檔案路徑
    /// </summary>
    public string? 檔名路徑 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime? 更新時間 { get; set; }

    public byte[]? 檔案實體 { get; set; }
}
