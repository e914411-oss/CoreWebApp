using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 追溯追蹤電子申報串接清單
{
    public int 電子申報串接ID { get; set; }

    public int? 追溯追蹤稽查ID { get; set; }

    public string? 追溯追蹤系統串接碼 { get; set; }

    public string? 申報總淨重 { get; set; }
}
