using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_Enforcement
{
    public int GHP_Enforcement_Id { get; set; }

    public int GHPREC_ID { get; set; }

    public string? Product_Work_Type { get; set; }

    public string? Product_Type { get; set; }

    public DateOnly? NCHKDATE { get; set; }

    public string? Results { get; set; }

    public DateOnly? RECHK_Date { get; set; }
}
