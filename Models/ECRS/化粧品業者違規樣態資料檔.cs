using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者違規樣態資料檔
{
    public int 系統編號 { get; set; }

    public int? 化粧品業者稽查主檔ID { get; set; }

    public int? 樣態編號 { get; set; }

    public string? 稽查說明 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
