using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者稽查違反法條資料檔
{
    public int 系統編號 { get; set; }

    public int? 化粧品業者稽查主檔ID { get; set; }

    public int? 違反法條編號 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
