using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Drugs_Search
{
    public int DC_Check_Id { get; set; }

    public string? Check_dateT { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Industry_Names { get; set; }

    public string? Addr { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Product_Name { get; set; }

    public string? SYS_Value { get; set; }

    public DateTime? Check_date { get; set; }

    public string City_ID { get; set; } = null!;

    public string County_ID { get; set; } = null!;

    public string? Signboard_Address { get; set; }

    public string? Industry_Values { get; set; }

    public string? SYS_Code { get; set; }

    public string? Inspector { get; set; }

    public DateTime? Improve_Date { get; set; }
}
