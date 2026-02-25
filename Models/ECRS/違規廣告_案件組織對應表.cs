using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件組織對應表
{
    public string 組織流水號 { get; set; } = null!;

    public int 違規案件編號 { get; set; }

    public string 案件資料類型權限 { get; set; } = null!;
}
