using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品稽查銷售通路表
{
    public int 物品稽查銷售通路表_主鍵 { get; set; }

    public int 物品稽查編號 { get; set; }

    public string 銷售通路選項代碼 { get; set; } = null!;

    public string 類型 { get; set; } = null!;

    public string? 業者名稱 { get; set; }

    public string? 填報人員 { get; set; }

    public DateTime? 填報時間 { get; set; }
}
