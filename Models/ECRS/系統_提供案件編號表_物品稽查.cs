using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_提供案件編號表_物品稽查
{
    public int 主鍵 { get; set; }

    public string 編號_年 { get; set; } = null!;

    public string 地區代號 { get; set; } = null!;

    public string 編號_流水號 { get; set; } = null!;
}
