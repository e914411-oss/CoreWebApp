using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案_稽查區域對應表
{
    public int 稽查區域對應編號 { get; set; }

    public string? 稽查區域名稱 { get; set; }

    public string? 稽查區域編號 { get; set; }

    public string? 縣市編號 { get; set; }

    public string? 區域編號 { get; set; }
}
