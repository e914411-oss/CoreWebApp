using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_AP_User
{
    public string UsrUid { get; set; } = null!;

    public string? DptCode { get; set; }

    public string? UsrName { get; set; }

    public string? Mail { get; set; }

    public DateTime? Upd_Time { get; set; }

    public string? Mobile { get; set; }

    public string? UsrOtel { get; set; }

    public string? User_Identity { get; set; }

    public string? Pwd { get; set; }

    public string? LoginID { get; set; }
}
