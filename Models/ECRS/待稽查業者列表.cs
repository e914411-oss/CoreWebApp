using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 待稽查業者列表
{
    public int 主鍵 { get; set; }

    public string? 使用人員主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 2:已稽查
    /// </summary>
    public int? 資料狀態 { get; set; }

    /// <summary>
    /// 刪除註記(Y:已刪除, N或空白或Null:未刪除)
    /// </summary>
    public string? 刪除註記 { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? 排序 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 註解 { get; set; }
}
