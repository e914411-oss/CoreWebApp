using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品稽查主表
{
    public int 物品稽查主表編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public int 稽查類型 { get; set; }

    public string 產品編號 { get; set; } = null!;

    public string 物品名稱 { get; set; } = null!;
}
