using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件廠商處分作業
{
    public string 違規案件編號 { get; set; } = null!;

    public string 受處分主體 { get; set; } = null!;

    public int 罰款 { get; set; }

    public string 處分字號 { get; set; } = null!;
}
