using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_WSVC_Industry_GOODSKIND
{
    public int ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? FMT_NO { get; set; }

    public string? FDT_NO { get; set; }

    public string? FDDT_NO { get; set; }
}
