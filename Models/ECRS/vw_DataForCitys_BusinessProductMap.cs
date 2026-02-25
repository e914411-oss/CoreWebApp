using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_BusinessProductMap
{
    public int 主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 產品別主分類主鍵 { get; set; }

    public string? 產品別次分類主鍵 { get; set; }

    public string? 產品別細分類主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 檢驗系統_檢體主分類代碼 { get; set; }

    public string? 檢驗系統_檢體大分類代碼 { get; set; }

    public string? 檢驗系統_檢體中分類代碼 { get; set; }

    public string? 檢驗系統_檢體小分類代碼 { get; set; }

    public string? 檢驗系統_檢體分類代碼 { get; set; }
}
