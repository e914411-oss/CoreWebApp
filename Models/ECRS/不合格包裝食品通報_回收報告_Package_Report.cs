using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_回收報告_Package_Report
{
    public int Package_Report_Id { get; set; }

    public int? Package_Main_Id { get; set; }

    public DateOnly? S_Rep_Time { get; set; }

    public DateOnly? E_Rep_Time { get; set; }

    public string? Rep_Num { get; set; }

    public string? Rep_Unit { get; set; }

    public string? Rep_City { get; set; }
}
