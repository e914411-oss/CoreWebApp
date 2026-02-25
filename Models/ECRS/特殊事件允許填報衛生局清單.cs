using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件允許填報衛生局清單
{
    public int 允許填報衛生局清單編號 { get; set; }

    public int? 特殊事件通報主檔編號 { get; set; }

    public string? 衛生局編號 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
