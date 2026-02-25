using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class A_TMP
{
    public int 稽查id { get; set; }

    public int? 上一次複查id { get; set; }

    public string? 是否為複查 { get; set; }

    public string? 第幾次複查 { get; set; }
}
