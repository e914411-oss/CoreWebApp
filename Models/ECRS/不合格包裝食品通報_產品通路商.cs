using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_產品通路商
{
    public int 不合格包裝食品通報_產品通路商_主鍵 { get; set; }

    public int 不合格包裝食品通報_主表_主鍵 { get; set; }

    public string? 通路商代碼 { get; set; }
}
