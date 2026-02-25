using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 追溯追蹤工作紀錄
{
    public int 工作紀錄ID { get; set; }

    public int? 追溯追蹤稽查ID { get; set; }

    public string? 現場稽查描述 { get; set; }
}
