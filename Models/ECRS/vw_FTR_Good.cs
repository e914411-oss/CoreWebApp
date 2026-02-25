using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_FTR_Good
{
    public DateTime? DataDate { get; set; }

    public string APPL_NO { get; set; } = null!;

    public string CCCCODE { get; set; } = null!;

    public string? GOODSNAME { get; set; }

    public string? GOODSNAME_E { get; set; }

    public string? SPEC { get; set; }

    public string? PRODUCTCOUNTRY { get; set; }

    public string? PRODUCTCOUNTRYName { get; set; }

    public decimal? IN_AMT { get; set; }

    public string? IN_AMT_UNIT { get; set; }

    public decimal? DECLQUANTITY { get; set; }

    public string? COMM_AMT_UNIT { get; set; }
}
