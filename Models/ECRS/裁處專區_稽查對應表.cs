using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處專區_稽查對應表
{
    public int 主鍵 { get; set; }

    public int 裁處系統主表主鍵 { get; set; }

    public int? 稽查類型 { get; set; }

    public int? 各稽查類型系統編號 { get; set; }

    public string? 建立人員 { get; set; }
}
