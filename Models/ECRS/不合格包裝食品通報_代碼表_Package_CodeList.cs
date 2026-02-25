using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_代碼表_Package_CodeList
{
    public int Id { get; set; }

    public string? Code_Type { get; set; }

    public string? Code_Key { get; set; }

    public string? Code_Value { get; set; }

    public string? STOP { get; set; }

    public string? City { get; set; }
}
