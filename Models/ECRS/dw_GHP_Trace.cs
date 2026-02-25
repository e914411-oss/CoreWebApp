using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_Trace
{
    public int GHP_Trace_Id { get; set; }

    public int GHPREC_ID { get; set; }

    public string? Product_Work_Type { get; set; }

    public string? Is_Electronic_Filing { get; set; }

    public string? Product_Type { get; set; }

    public string? Is_Gene_Reform { get; set; }

    public string? Is_Gene_NotReform { get; set; }

    public string? Results { get; set; }

    public DateOnly? RECHK_Date { get; set; }

    public string? Work_Records { get; set; }
}
