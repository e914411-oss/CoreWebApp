using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Fadenbook_Industry
{
    public string ID { get; set; } = null!;

    public string? DrCompany { get; set; }

    public string? DrCity { get; set; }

    public string? DrArea { get; set; }

    public string? DrStreet { get; set; }

    public string? DrTel { get; set; }

    public string? DrLogNo { get; set; }

    public string? DrSign { get; set; }

    public string? type { get; set; }

    public DateTime? LastD { get; set; }

    public string DrCode { get; set; } = null!;

    public int CoSno { get; set; }

    public string? FaAffix { get; set; }

    public string? DrBusin { get; set; }

    public string? DrCityTu { get; set; }

    public string? DrAreaTu { get; set; }

    public string? DrStreetTu { get; set; }
}
