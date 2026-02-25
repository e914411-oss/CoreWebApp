using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品衛生報表工作表_暫存_108年版
{
    public int? 報表產品代碼流水號 { get; set; }

    public string 報表01_檢驗類別主類編號 { get; set; } = null!;

    public string 報表01_檢驗類別次類編號 { get; set; } = null!;

    public string 總和測試號碼 { get; set; } = null!;

    public string 批次號碼 { get; set; } = null!;

    public string 暫存檢驗類 { get; set; } = null!;
}
