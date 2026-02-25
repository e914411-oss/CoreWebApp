using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_RecList
{
    public int ID { get; set; }

    public string? pType { get; set; }

    public string? pTypeID { get; set; }

    public string? PROJECTS_IDs { get; set; }

    public int? Check_List_ID { get; set; }

    public string? Trans_LIMS { get; set; }
}
