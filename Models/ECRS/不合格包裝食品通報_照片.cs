using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_照片
{
    public int 不合格包裝食品通報_照片_主鍵 { get; set; }

    public int? 不合格包裝食品通報_主表_主鍵 { get; set; }

    public string? 大圖 { get; set; }

    public string? 縮圖 { get; set; }

    public byte[]? 圖片原始檔 { get; set; }
}
