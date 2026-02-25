using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_明細表
{
    public int 主鍵 { get; set; }

    public int? 刑責回報專區_主表主鍵 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 違反法條 { get; set; }

    public string? 違反法條_文字 { get; set; }

    public string? 違規情節 { get; set; }

    public string? 違規情節_無違規 { get; set; }

    public string? 違規情節_行政處分 { get; set; }

    public string? 違規情節_刑事責任 { get; set; }

    public string? 移送單位 { get; set; }

    public DateOnly? 移送日期 { get; set; }

    public string? 移送日期_國曆 { get; set; }

    public string? 移送文號 { get; set; }

    public string? 偵查結果 { get; set; }

    public string? 偵查結果_其他 { get; set; }

    public string? 起訴事實 { get; set; }

    public int? 裁處編號 { get; set; }

    public string? 裁處發文字號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
