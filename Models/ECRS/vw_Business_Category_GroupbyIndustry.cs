using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Business_Category_GroupbyIndustry
{
    public int? Industry_ID { get; set; }

    public string? Main_ID { get; set; }

    public string? Sub_ID { get; set; }

    public string? Main_Name { get; set; }

    public string? Sub_Name { get; set; }

    public string? Full_Name { get; set; }
}
