using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_標示查核結果
{
    public int 物品稽查編號 { get; set; }

    public int Check_List_ID { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? City_ID { get; set; }

    public string? County_ID { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? 檢驗系統_檢體主分類代碼 { get; set; }

    public string? 檢驗系統_檢體大分類代碼 { get; set; }

    public string? 檢驗系統_檢體中分類代碼 { get; set; }

    public string? 檢驗系統_檢體小分類代碼 { get; set; }

    public string? 檢驗系統_檢體分類代碼 { get; set; }

    public string? 檢驗系統_檢體主分類名稱 { get; set; }

    public string? 檢驗系統_檢體大分類名稱 { get; set; }

    public string? 檢驗系統_檢體中分類名稱 { get; set; }

    public string? 檢驗系統_檢體小分類名稱 { get; set; }

    public string? 檢驗系統_檢體分類名稱 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 物品編號 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 專案編號 { get; set; }

    public string 稽查件數 { get; set; } = null!;

    public int? 標示_查驗類型編號 { get; set; }

    public string? showFinish { get; set; }
}
