using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class PMDS_郵遞區號城市_匹配
{
    public int 郵遞區號 { get; set; }

    public string? 區名 { get; set; }

    public string? 縣市代號 { get; set; }

    public string? 區域代號 { get; set; }
}
