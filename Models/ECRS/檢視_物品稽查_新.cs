using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_新
{
    public int? 物品稽查編號 { get; set; }

    public string? ORG { get; set; }

    public string? External_Key_Industry_ID { get; set; }

    public string? Signboard_Name { get; set; }

    public int Industry_ID { get; set; }

    public string? Company_Name { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Telephone { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 檢驗系統_檢體主分類代碼 { get; set; }

    public string? 檢驗系統_檢體大分類代碼 { get; set; }

    public string? 檢驗系統_檢體中分類代碼 { get; set; }

    public string? 檢驗系統_檢體小分類代碼 { get; set; }

    public string? 檢驗系統_檢體分類代碼 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 專案編號 { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 標示稽查 { get; set; }

    public string? 熟食稽查 { get; set; }

    public string? 油炸油稽查 { get; set; }

    public int Check_List_ID { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商地址 { get; set; }

    public string 稽查件數 { get; set; } = null!;

    public string? 製造商名稱 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 熟食_稽查件數 { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? 專案名稱 { get; set; }

    public string inspectorsName { get; set; } = null!;

    public string undertakersName { get; set; } = null!;

    public string? Country_of_Origin { get; set; }

    public string? status { get; set; }

    public string? City_ID { get; set; }

    public string? County_ID { get; set; }

    public string Business_Address { get; set; } = null!;

    public string? inspected_items { get; set; }

    public string? inspectors_Unit { get; set; }

    public string? cookFinish { get; set; }

    public string? LabFinish { get; set; }

    public string? showFinish { get; set; }

    public string? OilFinish { get; set; }

    public string? ViolationNumber_Authorized { get; set; }

    public string? RESULT_Authorized { get; set; }

    public string? Authorized_Cooked_Illegal_Number { get; set; }

    public string? Authorized_Oil_Illegal_Number { get; set; }

    public string? Product_Main { get; set; }

    public string? Product_Sub { get; set; }

    public string? Product_Third { get; set; }

    public string? 物品編號 { get; set; }

    public string? 檢驗系統_檢體主分類名稱 { get; set; }

    public string? 檢驗系統_檢體大分類名稱 { get; set; }

    public string? 檢驗系統_檢體中分類名稱 { get; set; }

    public string? 檢驗系統_檢體小分類名稱 { get; set; }

    public string? 檢驗系統_檢體分類名稱 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }

    public string? Rechk { get; set; }

    public string? External_Key { get; set; }

    public string? 油炸油_稽查件數 { get; set; }

    public string? 食品地區別 { get; set; }

    public int? 物品包裝代碼 { get; set; }

    public string? 來源商未標示 { get; set; }

    public string? 製造商未標示 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 檢驗結果報告日期 { get; set; }

    public DateOnly? 檢驗結果報告日期起 { get; set; }

    public DateOnly? 檢驗結果報告日期迄 { get; set; }
}
