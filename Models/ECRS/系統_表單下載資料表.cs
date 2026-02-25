using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_表單下載資料表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 目錄Id
    /// </summary>
    public int? 表單分類檔主鍵 { get; set; }

    public string? 表單名稱 { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    public string? 檔案名稱 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    public byte[]? 檔案資料 { get; set; }
}
