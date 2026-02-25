using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品衛生報表工作表_暫存
{
    public string 報表01_產品類別主類編號 { get; set; } = null!;

    public string 報表01_產品類別次類編號 { get; set; } = null!;

    public string 報表01_檢驗類別主類編號 { get; set; } = null!;

    public string 報表01_檢驗類別次類編號 { get; set; } = null!;

    public string 總和測試號碼 { get; set; } = null!;

    public string 批次號碼 { get; set; } = null!;

    public string 暫存產品類 { get; set; } = null!;

    public string 暫存檢驗類 { get; set; } = null!;
}
