using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_標示稽查紀錄
{
    public Guid 標示稽查紀錄編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }

    public string? 物品標示稽查類別 { get; set; }

    public string? 查驗類別名稱 { get; set; }

    public string? 查驗條文名稱 { get; set; }

    public string? 查核結果 { get; set; }
}
