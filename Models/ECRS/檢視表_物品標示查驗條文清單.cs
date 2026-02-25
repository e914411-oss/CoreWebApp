using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視表_物品標示查驗條文清單
{
    public string? 查驗類型名稱 { get; set; }

    public string? 查驗類別名稱 { get; set; }

    public string? 查驗條文名稱 { get; set; }

    public int 查驗類型編號 { get; set; }

    public int 查驗類別編號 { get; set; }

    public int 查驗條文編號 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateOnly? 上線日期 { get; set; }

    public string? 查核結果選項 { get; set; }
}
