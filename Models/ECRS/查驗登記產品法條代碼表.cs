using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品法條代碼表
{
    public int 主鍵 { get; set; }

    public int? FMS介接主鍵 { get; set; }

    public string? 法條 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }

    public string? 產品類型代碼 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 法條內容 { get; set; }
}
