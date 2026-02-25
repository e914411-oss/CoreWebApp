using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處系統_法令依據範本
{
    public int 主鍵 { get; set; }

    public string? 法條類別名稱 { get; set; }

    public string? 法令說明 { get; set; }
}
