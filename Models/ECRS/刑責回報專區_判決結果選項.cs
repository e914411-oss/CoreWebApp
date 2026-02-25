using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_判決結果選項
{
    public int 主鍵 { get; set; }

    public string? 判決結果名稱 { get; set; }

    public DateTime? 新增日期 { get; set; }

    public string? 新增人員 { get; set; }
}
