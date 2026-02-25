using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_異動歷程
{
    public int 主鍵 { get; set; }

    public int? 刑責回報專區_主表主鍵 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 紀錄時間 { get; set; }

    public string? 動作 { get; set; }
}
