using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_HACCP_Rules_Milk
{
    public int HACCP_Rule_R_id { get; set; }

    public int? importantance { get; set; }

    public string? Rule_Text { get; set; }

    public int? No_1 { get; set; }

    public int? No_2 { get; set; }

    public int? No_3 { get; set; }

    public bool? Title_mark { get; set; }

    public bool? inspect_doc { get; set; }

    public bool? inspect_scene { get; set; }

    public bool? major_defects { get; set; }
}
