using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Industry_Product_Category_Map
{
    public int ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? Product_Category_Main_ID { get; set; }

    public string? Product_Category_Sub_ID { get; set; }

    public string? Product_Category_Third_ID { get; set; }

    public string? TPEPK { get; set; }
}
