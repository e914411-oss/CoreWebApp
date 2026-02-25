using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視表_物品標示稽查條文對應清單
{
    public int 查驗類型編號 { get; set; }

    public int? 查驗類別編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public string 查核結果 { get; set; } = null!;
}
