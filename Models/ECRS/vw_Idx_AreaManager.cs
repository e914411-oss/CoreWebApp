using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Idx_AreaManager
{
    public string DeptCode { get; set; } = null!;

    public string? DeptName { get; set; }

    public string? UsrName { get; set; }

    public int RoleId { get; set; }

    public string? AreaName { get; set; }

    public string UsrUid { get; set; } = null!;

    public string? UserDisplayname { get; set; }

    public string? status { get; set; }
}
