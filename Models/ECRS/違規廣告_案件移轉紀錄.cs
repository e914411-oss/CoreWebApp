using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件移轉紀錄
{
    public int 案例流水號 { get; set; }

    public string 違規案件編號 { get; set; } = null!;

    public string 使用者帳號 { get; set; } = null!;

    public string 動作 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string? 移查對象 { get; set; }

    /// <summary>
    /// 移查文號
    /// </summary>
    public string? 移查文號 { get; set; }

    /// <summary>
    /// 發文日期
    /// </summary>
    public DateTime? 發文日期 { get; set; }

    /// <summary>
    /// 發文字號
    /// </summary>
    public string? 發文字號 { get; set; }

    /// <summary>
    /// 收文日期
    /// </summary>
    public DateTime? 收文日期 { get; set; }

    /// <summary>
    /// 收文文號
    /// </summary>
    public string? 收文文號 { get; set; }

    /// <summary>
    /// 移查日期
    /// </summary>
    public DateTime? 移查日期 { get; set; }

    public int? 函詢天數 { get; set; }
}
