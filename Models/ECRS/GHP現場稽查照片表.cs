using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP現場稽查照片表
{
    public int 主鍵 { get; set; }

    public int GHP現場明細表主鍵 { get; set; }

    public byte[] 照片檔案 { get; set; } = null!;

    public string? 衛生局主鍵 { get; set; }

    public string? 名稱 { get; set; }
}
