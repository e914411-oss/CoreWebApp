using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒檢驗類別表
{
    public int? 食品中毒檢驗主類別_主鍵 { get; set; }

    public string? 檢驗項目名稱 { get; set; }

    public string? 中毒檢驗主類別名稱 { get; set; }

    public int 食品中毒檢驗次類別_主鍵 { get; set; }

    public string? 檢驗項目代號 { get; set; }

    public string? 檢驗項目說明 { get; set; }

    public int? 排序 { get; set; }

    public string? 是否啟用 { get; set; }
}
