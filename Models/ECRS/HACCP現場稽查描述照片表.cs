using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP現場稽查描述照片表
{
    public int 主鍵 { get; set; }

    public int? HACCP現場稽查描述表主鍵 { get; set; }

    public byte[]? 照片檔案 { get; set; }
}
