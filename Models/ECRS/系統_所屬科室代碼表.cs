using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_所屬科室代碼表
{
    public int 流水編號 { get; set; }

    public string? 所屬科室類型 { get; set; }

    public string? 所屬科室代碼 { get; set; }

    public string? 所屬科室名稱 { get; set; }

    public int? 排序 { get; set; }
}
