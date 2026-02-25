using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品標示內容對應
{
    public int 物品稽查編號 { get; set; }

    public int? 標示類別編號 { get; set; }

    public string? CodeName { get; set; }

    public int? 標示項目編號 { get; set; }

    public string? DetailName { get; set; }

    public string? 標示結果內容 { get; set; }
}
