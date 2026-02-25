using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品明細
{
    public int ID { get; set; }

    public string? pType { get; set; }

    public int 稽查主檔編號 { get; set; }

    public string? 物品編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }

    public string? 抽驗_違規件數 { get; set; }

    public string? 檢驗判定 { get; set; }

    public string? 移外縣市編號 { get; set; }

    public string? 縣市名稱 { get; set; }
}
