using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品標示查驗類型清單
{
    public int 查驗類型編號 { get; set; }

    public string? 查驗類型名稱 { get; set; }

    public DateTime? 建立日期 { get; set; }
}
