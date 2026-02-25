using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_個人範本主表
{
    /// <summary>
    /// 目錄識別碼
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 衛生局代碼(等於縣市代碼)
    /// </summary>
    public string? 縣市主鍵 { get; set; }

    /// <summary>
    /// 使用者代碼
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    public string? 目錄名稱 { get; set; }

    /// <summary>
    /// 父層目錄
    /// </summary>
    public int? 父層目錄 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 最後修改時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? 排序 { get; set; }

    /// <summary>
    /// 是否為目錄
    /// </summary>
    public bool 是否為目錄 { get; set; }

    public string? 階層 { get; set; }

    public bool 是否為縣市範本 { get; set; }
}
