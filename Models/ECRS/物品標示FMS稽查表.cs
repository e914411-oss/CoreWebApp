using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品標示FMS稽查表
{
    /// <summary>
    /// 物品標示序號
    /// </summary>
    public int 物品標示FMS稽查編號 { get; set; }

    /// <summary>
    /// 物品稽查序號
    /// </summary>
    public int 物品稽查編號 { get; set; }

    /// <summary>
    /// 標示類別編號(如:代碼檔咖啡因標示之ID)
    /// </summary>
    public int? 標示類別編號 { get; set; }

    /// <summary>
    /// 標示項目編號(如:代碼檔包裝之ID)
    /// </summary>
    public int? 標示項目編號 { get; set; }

    /// <summary>
    /// 標示結果代碼ID(如非下拉選單可不填寫)
    /// </summary>
    public int? 標示結果編號 { get; set; }

    /// <summary>
    /// 標示結果內容(如合格,3件等...)
    /// </summary>
    public string? 標示結果內容 { get; set; }
}
