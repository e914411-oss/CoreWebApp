using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_判決結果
{
    public int 主鍵 { get; set; }

    public int? 刑責回報專區_主表主鍵 { get; set; }

    public DateOnly? 裁判日期 { get; set; }

    public int? 判決結果 { get; set; }

    public string? 裁判法院 { get; set; }

    public string? 裁判字號 { get; set; }

    public string? 裁判主文 { get; set; }
}
