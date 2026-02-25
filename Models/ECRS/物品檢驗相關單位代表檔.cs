using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品檢驗相關單位代表檔
{
    public int 檢驗相關單位代碼 { get; set; }

    public string? 系統部門編號 { get; set; }

    public string? 單位類別名稱 { get; set; }

    public string? 單位名稱 { get; set; }
}
