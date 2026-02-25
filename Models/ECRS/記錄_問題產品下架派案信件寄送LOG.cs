using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_問題產品下架派案信件寄送LOG
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    public string 問題產品案件編號 { get; set; } = null!;

    public int 案件階層 { get; set; }

    public string 類型 { get; set; } = null!;

    public string 派案群組 { get; set; } = null!;

    public string 郵件伺服器IP { get; set; } = null!;

    /// <summary>
    /// 寄送的E-Mail
    /// </summary>
    public string 寄送信箱 { get; set; } = null!;

    public string 寄送狀態 { get; set; } = null!;

    public string 主旨 { get; set; } = null!;

    public string 內容 { get; set; } = null!;

    /// <summary>
    /// 使用者代碼
    /// </summary>
    public string 使用者 { get; set; } = null!;

    /// <summary>
    /// 發送時間
    /// </summary>
    public DateTime 建立時間 { get; set; }
}
