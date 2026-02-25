using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class City1
{
    public string City_ID { get; set; } = null!;

    public string? City_Name { get; set; }

    public string? Del_MK { get; set; }

    public DateTime? City_MODDATE { get; set; }

    public string? ModUser { get; set; }

    public string? RECHK_Flag { get; set; }

    public bool? Captain_Need { get; set; }
}
