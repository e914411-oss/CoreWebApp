using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_CHKItem
{
    public int ChkItemID { get; set; }

    public string? External_Key { get; set; }

    public string? Business_Category_Main_ID { get; set; }

    public string? ChkItemText { get; set; }

    public string? IsActive { get; set; }

    public DateTime? CHKItems_MODDATE { get; set; }

    public string? Moduser { get; set; }

    public int? Sort { get; set; }
}
