using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者稽查專案表
{
    public int 主鍵 { get; set; }

    public int? 化粧品業者稽查主檔ID { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
