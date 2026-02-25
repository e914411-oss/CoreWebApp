using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_MeatChk
{
    public int MeatChkID { get; set; }

    public int GHPREC_ID { get; set; }

    public int MeatChkItemID { get; set; }

    public string MeatChkResultID { get; set; } = null!;

    public string MeatChkResultName { get; set; } = null!;

    public string? TPEPK { get; set; }

    public DateTime? MODDATE { get; set; }
}
