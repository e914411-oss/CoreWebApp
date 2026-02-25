using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_回收報告_作業地區_Package_Report_City
{
    public int Package_ReportCity_Id { get; set; }

    public int? Package_Main_Id { get; set; }

    public string? Rep_City { get; set; }

    public string? Status { get; set; }
}
