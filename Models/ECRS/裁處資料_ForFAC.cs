using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料_ForFAC
{
    public int 裁處編號 { get; set; }

    public string? 衛生局 { get; set; }

    public string? 稽查項目 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 處分對象 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 受處分人營業地址 { get; set; }

    public string? 裁處法條 { get; set; }

    public string? 違反法條 { get; set; }

    public string? 行政處份 { get; set; }

    public string? 狀態 { get; set; }

    public DateTime? 稽查更新日期 { get; set; }
}
