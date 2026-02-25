using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 一級品管稽查工作紀錄
{
    public int 工作紀錄ID { get; set; }

    public int? 一級品管ID { get; set; }

    public string? 現場稽查描述 { get; set; }
}
