using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_照片_Package_Pic
{
    public int Package_Pic_Id { get; set; }

    public int? Package_Main_Id { get; set; }

    public string? Big_Pic { get; set; }

    public string? Small_Pic { get; set; }

    public byte[]? Source_Pic { get; set; }
}
