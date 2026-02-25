using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dc_CheckOrg
{
    public int 化粧品稽查明細表主鍵 { get; set; }

    public int? 化粧品稽查主表主鍵 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? ORG { get; set; }
}
