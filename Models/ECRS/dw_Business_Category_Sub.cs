using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Business_Category_Sub
{
    public string Business_Category_Sub_ID { get; set; } = null!;

    public string? Business_Category_Sub_Name { get; set; }

    public string Business_Category_Main_ID { get; set; } = null!;

    public string? STOP { get; set; }

    public int Id { get; set; }

    public DateTime? Business_Category_Sub_MODDATE { get; set; }

    public string? ModUser { get; set; }
}
