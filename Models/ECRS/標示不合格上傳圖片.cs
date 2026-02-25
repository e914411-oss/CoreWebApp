using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 標示不合格上傳圖片
{
    public int 系統流水號 { get; set; }

    public int? 稽查類型 { get; set; }

    public int? 對應系統編號 { get; set; }

    public string? 圖檔名稱 { get; set; }

    public string? 大圖 { get; set; }

    public string? 小圖 { get; set; }

    public byte[]? 原始圖 { get; set; }
}
