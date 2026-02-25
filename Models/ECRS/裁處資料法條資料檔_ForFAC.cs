using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料法條資料檔_ForFAC
{
    public string? 法條類別 { get; set; }

    public int 法條系統編號 { get; set; }

    public int 裁處編號 { get; set; }

    public string 法條名稱 { get; set; } = null!;

    public string? 裁處法條_條 { get; set; }

    public string? 裁處法條_項 { get; set; }

    public string? 裁處法條_款 { get; set; }
}
