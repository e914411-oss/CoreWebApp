using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_新_報表群組
{
    public int 物品稽查編號 { get; set; }

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

    public string? 物品名稱 { get; set; }

    public string? 專案編號 { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 標示稽查 { get; set; }

    public string? 熟食稽查 { get; set; }

    public int Check_List_ID { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商地址 { get; set; }

    public int? 稽查件數 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 熟食_稽查件數 { get; set; }

    public string? Food_Area_Type { get; set; }

    public string? Country_of_Origin_Manifest { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? Country_of_Origin { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? inspected_items { get; set; }

    public string? inspectors_Unit { get; set; }

    public string? cookFinish { get; set; }

    public string? showFinish { get; set; }

    public string? ViolationNumber_Authorized { get; set; }

    public string? 檢驗判定_Authorized { get; set; }

    public string? Authorized_熟食_違規件數 { get; set; }

    public string? Product_Main { get; set; }

    public string? Product_Sub { get; set; }

    public string? Product_Third { get; set; }

    public string? 物品編號 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }

    public string? Rechk { get; set; }

    public string? External_Key { get; set; }

    public string? 散裝食品_屠宰衛生檢查合格標誌或相關來源證明資料_合格與否 { get; set; }

    public string? 有容器或包裝食品_其它_屠宰衛生檢查合格標誌或相關來源證明資料_合格與否 { get; set; }

    public string? 有容器或包裝食品_營養標示_營養宣稱_合格與否 { get; set; }

    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及醫療效能_合格與否 { get; set; }

    public string? 有容器或包裝食品_標示及廣告詞句_符合未涉及不實誇張或易生誤解之情形_合格與否 { get; set; }

    public string? 直接供應飲食之場所_原料原產地_合格與否 { get; set; }

    public string? 散裝食品_原料原產地_合格與否 { get; set; }

    public string? 散裝食品_食品原產地_合格與否 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_歇業 { get; set; }

    public string? 處理情形_國曆限期改善日期 { get; set; }

    public string? 標示處理情形_罰鍰金額 { get; set; }

    public string? Label_移外縣市編號 { get; set; }

    public string? 處理情形_沒入銷毀件數 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public string? 處理情形_廢止許可證 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_米粉絲產品標示原則_合格與否 { get; set; }

    public string? 有容器或包裝食品_其他公告指定標示事項_米粉絲產品標示原則 { get; set; }

    public string City_ID { get; set; } = null!;

    public string County_ID { get; set; } = null!;

    public string? 油炸油稽查 { get; set; }
}
