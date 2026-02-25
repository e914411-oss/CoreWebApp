using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_WSVC_Industry_STOREKIND
{
    public int Id { get; set; }

    public int? Industry_ID { get; set; }

    public string? BMT_NO { get; set; }

    public string? BDT_NO { get; set; }
}
