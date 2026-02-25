using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Industry_Business_Category_Map
{
    public int ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? Business_Category_Main_ID { get; set; }

    public string? Business_Category_Sub_ID { get; set; }

    public string? TPEPK { get; set; }
}
