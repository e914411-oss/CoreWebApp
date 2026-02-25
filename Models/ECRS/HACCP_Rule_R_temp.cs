using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP_Rule_R_temp
{
    public string HACCP_Rule_R_id { get; set; } = null!;

    public int? importantance { get; set; }

    public string? Rule_Text { get; set; }

    public bool? Title_mark { get; set; }

    public int? No_1 { get; set; }

    public int? No_2 { get; set; }

    public int? No_3 { get; set; }

    public string? Business_Category_Main_ID { get; set; }

    public int? External_Key { get; set; }

    public bool? inspect_doc { get; set; }

    public bool? inspect_scene { get; set; }

    public bool? major_defects { get; set; }

    public string? IsActive { get; set; }
}
