using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_City
{
    public string City_ID { get; set; } = null!;

    public string? City_Name { get; set; }

    public string County_ID { get; set; } = null!;

    public string? County_Name { get; set; }

    public DateTime? City_MODDATE { get; set; }

    public DateTime? County_MODDATE { get; set; }
}
