using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class County1
{
    public string County_ID { get; set; } = null!;

    public string? County_Name { get; set; }

    public string? Del_MK { get; set; }

    public string City_ID { get; set; } = null!;

    public DateTime? County_MODDATE { get; set; }

    public string? ModUser { get; set; }

    public int? Sort { get; set; }
}
