using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHPCHK
{
    public int CHKGHP_ID { get; set; }

    public int? GHPREC_ID { get; set; }

    public string? External_Key { get; set; }

    public int? ChkItemID { get; set; }

    public string? ChkItemText { get; set; }

    public string? CHKFLAG { get; set; }

    public string? CHKREMARK { get; set; }

    public string? TPEPK { get; set; }

    public DateTime? MODDATE { get; set; }
}
