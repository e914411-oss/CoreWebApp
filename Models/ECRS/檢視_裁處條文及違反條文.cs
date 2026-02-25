using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_裁處條文及違反條文
{
    public int 系統編號 { get; set; }

    public string? 違反條文 { get; set; }

    public string? 裁處條文 { get; set; }
}
