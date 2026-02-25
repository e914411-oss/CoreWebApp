using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_Country
{
    public int Id { get; set; }

    public string? Country_ID { get; set; }

    public string? Country_Name { get; set; }

    public DateTime? LastEditTime { get; set; }
}
