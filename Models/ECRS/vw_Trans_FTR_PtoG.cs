using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Trans_FTR_PtoG
{
    public decimal ID { get; set; }

    public DateTime? DataDate { get; set; }

    public string APPL_NO { get; set; } = null!;

    public string CCCCODE { get; set; } = null!;

    public string? GOODSNAME { get; set; }

    public string? GOODSNAME_E { get; set; }

    public string? SPEC { get; set; }

    public string? PRODUCTCOUNTRY { get; set; }

    public string? PRODUCTCOUNTRYName { get; set; }

    public double? IN_AMTTotal { get; set; }

    public string? IN_AMT_UNIT { get; set; }

    public decimal? DECLQUANTITY { get; set; }

    public string? COMM_AMT_UNIT { get; set; }

    public string? External_Key { get; set; }

    public string? Place_ExKey { get; set; }

    public double? IN_AMT { get; set; }
}
