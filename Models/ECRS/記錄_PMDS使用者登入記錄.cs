using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS使用者登入記錄
{
    public decimal 主鍵 { get; set; }

    /// <summary>
    /// 功能類別 節點
    /// </summary>
    public int? 系統節點 { get; set; }

    /// <summary>
    /// A:新增  U:修改 D:刪除  Q:查詢
    /// </summary>
    public string? 作業類型 { get; set; }

    /// <summary>
    /// 資料Key值
    /// </summary>
    public string? 作業內容 { get; set; }

    /// <summary>
    /// 使用單位
    /// </summary>
    public string? 使用者部門識別碼 { get; set; }

    /// <summary>
    /// 使用者部門名稱
    /// </summary>
    public string? 使用者部門名稱 { get; set; }

    /// <summary>
    /// 使用者帳號
    /// </summary>
    public string? 使用者識別碼 { get; set; }

    public string? 使用者名稱 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? 建立時間 { get; set; }
}
