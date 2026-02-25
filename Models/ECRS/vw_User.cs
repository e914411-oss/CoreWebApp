using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_User
{
    public string UsrUid { get; set; } = null!;

    public string? UsrName { get; set; }

    public string? UsrOtel { get; set; }

    public string? UsrOExt { get; set; }

    public string? DptCode { get; set; }

    public string? OU { get; set; }

    public string? Country { get; set; }

    public string? Pwd { get; set; }

    public string? Mobile { get; set; }

    public string? Mail { get; set; }

    public DateTime? Create_Time { get; set; }

    public DateTime? Upd_Time { get; set; }

    public string? PosName { get; set; }

    public string? TokenID { get; set; }

    public string? ApplySource { get; set; }

    public string? DeptName { get; set; }

    public string? DeptCity { get; set; }

    public int? AreaId { get; set; }

    public int UserRole { get; set; }

    public string? ReadableCitys { get; set; }

    public string? LoginID { get; set; }

    public string? User_Identity { get; set; }

    public string? UserIdentity { get; set; }
}
