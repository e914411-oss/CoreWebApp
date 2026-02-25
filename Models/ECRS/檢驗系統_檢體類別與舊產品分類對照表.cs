using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統_檢體類別與舊產品分類對照表
{
    public int 系統編號 { get; set; }

    public string? 產品類別主類代碼 { get; set; }

    public string? 產品類別次類代碼 { get; set; }

    public string? 產品類別細類代碼 { get; set; }

    public string? 檢驗系統檢體類別代碼 { get; set; }

    public string? 檢體標準名稱編碼 { get; set; }
}
