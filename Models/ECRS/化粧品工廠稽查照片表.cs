using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品工廠稽查照片表
{
    public int 化粧品工廠稽查照片表主鍵 { get; set; }

    public int 化粧品工廠現場稽查描述表主鍵 { get; set; }

    public byte[] 照片 { get; set; } = null!;

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 照片檔名 { get; set; }
}
