using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Product_Category_Sub
{
    public string Product_Category_Sub_ID { get; set; } = null!;

    public string? Product_Category_Sub_Name { get; set; }

    public string Product_Category_Main_ID { get; set; } = null!;

    public string? STOP { get; set; }

    public int Id { get; set; }

    public DateTime? Product_Category_Sub_MODDATE { get; set; }

    public string? ModUser { get; set; }
}
