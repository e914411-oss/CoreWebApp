using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_產品通路商_Package_Store
{
    public int Package_Store_Id { get; set; }

    public int Package_Main_Id { get; set; }

    public string? Store { get; set; }
}
