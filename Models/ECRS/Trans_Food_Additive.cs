using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Trans_Food_Additive
{
    public string? Industry_Name { get; set; }

    public string? Industry_Adr { get; set; }

    public string? Industry_Tel { get; set; }

    public string? Industry_No { get; set; }

    public string? Industry_Person { get; set; }

    public string? Additives_CName { get; set; }

    public string? Additives_EName { get; set; }

    public string? License { get; set; }

    public string? License_Sta { get; set; }

    public DateOnly? License_Update { get; set; }

    public string? Additives_Type1 { get; set; }

    public string? Additives_Type1_Name { get; set; }

    public string? Additives_Type2 { get; set; }

    public string? Additives_Type2_Name { get; set; }

    public string? Additives_Type3 { get; set; }

    public string? Additives_Type3_Name { get; set; }

    public DateTime? License_Date { get; set; }

    public string? Additives_Country { get; set; }

    public string? Additives_Factory { get; set; }

    public string? Additives_Address { get; set; }

    public string? CONNEC_MNFTY_LICENSE { get; set; }

    public string? IN_MNFTY_REPSE_PERSON { get; set; }

    public string? IN_MNFTY_PHONE_NO { get; set; }
}
