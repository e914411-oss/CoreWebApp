using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_BusinessCategory
{
    public string Business_Category_Main_ID { get; set; } = null!;

    public string? Business_Category_Main_Name { get; set; }

    public string Business_Category_Sub_ID { get; set; } = null!;

    public string? Business_Category_Sub_Name { get; set; }

    public DateTime? Business_Category_Main_MODDATE { get; set; }

    public DateTime? Business_Category_Sub_MODDATE { get; set; }
}
