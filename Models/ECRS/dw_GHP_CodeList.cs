using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_CodeList
{
    public int Id { get; set; }

    public string? Code_Type { get; set; }

    public string? Code_Key { get; set; }

    public string? Code_Value { get; set; }

    public string? STOP { get; set; }

    public string? Sort { get; set; }
}
