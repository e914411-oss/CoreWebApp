using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Template_Test
{
    public int FolderID { get; set; }

    public string? CityID { get; set; }

    public string? UsrUid { get; set; }

    public string? FolderName { get; set; }

    public int? ParentID { get; set; }

    public int? Sort { get; set; }

    public bool IsFolder { get; set; }
}
