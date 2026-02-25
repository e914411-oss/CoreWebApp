using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 瘦身美容業違反法條表
{
    public int 瘦身美容業違反法條表主鍵 { get; set; }

    public int? 瘦身美容業稽查主表主鍵 { get; set; }

    public int? 條文主鍵 { get; set; }

    public string? 條文類別 { get; set; }

    public string? 法條說明 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
