using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class PMDS_機構_業別匹配
{
    public int 主鍵 { get; set; }

    public string? 機構代碼 { get; set; }

    public string? 機構主代碼 { get; set; }

    public string? 機構次代碼 { get; set; }
}
