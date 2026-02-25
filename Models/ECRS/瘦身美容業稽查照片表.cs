using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 瘦身美容業稽查照片表
{
    public int 瘦身美容業稽查照片表主鍵 { get; set; }

    public int 瘦身美容現場稽查描述表主鍵 { get; set; }

    public byte[] 照片檔案 { get; set; } = null!;

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 照片名稱 { get; set; }
}
