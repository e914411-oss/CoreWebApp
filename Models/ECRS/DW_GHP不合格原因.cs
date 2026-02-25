using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class DW_GHP不合格原因
{
    public int GHP稽查ID { get; set; }

    public string? 稽查不合格項目 { get; set; }

    public string? 備註 { get; set; }
}
