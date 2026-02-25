using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視表_檢驗系統檢體類別階層選單
{
    public string? 檢驗系統_主分類代碼 { get; set; }

    public string 檢驗系統_大分類代碼 { get; set; } = null!;

    public string 檢驗系統_中分類代碼 { get; set; } = null!;

    public string 檢驗系統_小分類代碼 { get; set; } = null!;

    public string 檢驗系統_檢體分類代碼 { get; set; } = null!;

    public string? 檢驗系統_主分類名稱 { get; set; }

    public string? 檢驗系統_大分類名稱 { get; set; }

    public string? 檢驗系統_中分類名稱 { get; set; }

    public string? 檢驗系統_小分類名稱 { get; set; }

    public string 檢驗系統_檢體分類名稱 { get; set; } = null!;

    public byte 是否停用 { get; set; }
}
