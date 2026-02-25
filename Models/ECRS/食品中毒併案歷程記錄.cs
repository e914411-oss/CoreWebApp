using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒併案歷程記錄
{
    public int 歷程編號 { get; set; }

    public string 主案中毒案件編號 { get; set; } = null!;

    public int 主案中毒系統編號 { get; set; }

    public string 併案中毒案件編號 { get; set; } = null!;

    public int 併案中毒系統編號 { get; set; }

    public DateTime 併案時間 { get; set; }

    public string 併案人員系統編號 { get; set; } = null!;

    public string 併案人員單位 { get; set; } = null!;
}
