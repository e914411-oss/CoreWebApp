using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_業者登錄字號對應表
{
    public int 業者登錄字號對應表編號 { get; set; }

    public int? 業者編號 { get; set; }

    public string? 登錄字號 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
