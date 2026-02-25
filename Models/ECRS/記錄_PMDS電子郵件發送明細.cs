using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS電子郵件發送明細
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// &apos;A&apos; 審核通過 &apos;F&apos; 忘記密碼 &apos;P&apos;中毒通知
    /// </summary>
    public string? 類型 { get; set; }

    /// <summary>
    /// 使用者代碼
    /// </summary>
    public string? 使用者 { get; set; }

    /// <summary>
    /// 申請忘記密碼IP
    /// </summary>
    public string? 郵件伺服器IP { get; set; }

    /// <summary>
    /// 寄送的E-Mail
    /// </summary>
    public string? 寄送信箱 { get; set; }

    public string? 主旨 { get; set; }

    public string? 內容 { get; set; }

    /// <summary>
    /// 發送時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
