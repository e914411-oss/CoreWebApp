using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Business_Category
{
    public int? Industry_ID { get; set; }

    public string? Business_Category_Main_ID { get; set; }

    public string? Business_Category_Main_Name { get; set; }

    public string? Business_Category_Sub_ID { get; set; }

    public string? Business_Category_Sub_Name { get; set; }
}
