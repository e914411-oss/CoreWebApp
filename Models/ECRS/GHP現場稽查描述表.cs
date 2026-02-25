using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP現場稽查描述表
{
    public int 主鍵 { get; set; }

    public int GHP稽查主表主鍵 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }
}
