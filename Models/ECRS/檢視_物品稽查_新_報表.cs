using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_新_報表
{
    public int 物品稽查編號 { get; set; }

    public string? ORG { get; set; }

    public string? External_Key_Industry_ID { get; set; }

    public string? Signboard_Name { get; set; }

    public int Industry_ID { get; set; }

    public string? Company_Name { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Telephone { get; set; }

    public string? 統一編號 { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 檢驗系統_檢體主分類代碼 { get; set; }

    public string? 檢驗系統_檢體大分類代碼 { get; set; }

    public string? 檢驗系統_檢體中分類代碼 { get; set; }

    public string? 檢驗系統_檢體小分類代碼 { get; set; }

    public string? 檢驗系統_檢體分類代碼 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 專案名稱 { get; set; }

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

    public string? Food_Area_Type { get; set; }

    public string? Country_of_Origin_Manifest { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? Country_of_Origin { get; set; }

    public string? status { get; set; }

    public string inspectorsName { get; set; } = null!;

    public string undertakersName { get; set; } = null!;

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? inspected_items { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }

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

    public string? Inspectors_Name { get; set; }

    public string? 食品地區別 { get; set; }

    public string? 抽驗處理情形_移送法院 { get; set; }

    public string? 處理情形_飭其收回重製 { get; set; }

    public string? 處理情形_禁止出售或沒收 { get; set; }

    public string? 抽驗處理情形_停業 { get; set; }

    public string? Dispose_OUTCOUNTRY { get; set; }

    public string? 處理情形_廢棄重量_公斤 { get; set; }

    public string? 處理情形_罰款金額 { get; set; }

    public string? 處理情形_廢止營業或工廠登記證號 { get; set; }

    public string? 標示處理情形_移送法院 { get; set; }

    public string? 處理情形_產品定期封存 { get; set; }

    public string? 標示處理情形_停業 { get; set; }

    public string? 處理情形_歇業 { get; set; }

    public string? 處理情形_國曆限期改善日期 { get; set; }

    public string? 標示處理情形_罰鍰金額 { get; set; }

    public string? Label_OUTCOUNTRY { get; set; }

    public string? 處理情形_沒入銷毀件數 { get; set; }

    public DateOnly? 處理情形_限期改善日期 { get; set; }

    public string? 抽驗處理情形_限期改善 { get; set; }

    public string? 標示處理情形_限期改善 { get; set; }

    public string? 處理情形_廢止許可證 { get; set; }

    public double? 油炸油_酸價快篩_檢驗值 { get; set; }

    public double? 油炸油_總極性物質快篩_檢驗值 { get; set; }

    public string? 油炸油_酸價快篩_快篩結果 { get; set; }

    public string? 油炸油_總極性物質快篩_快篩結果 { get; set; }

    public string? City_ID { get; set; }

    public string? County_ID { get; set; }

    public string? 處理情形_移其他單位辦理 { get; set; }

    public string? 處理情形_國曆複驗合格日期 { get; set; }

    public string? 處理情形_複驗合格 { get; set; }

    public string? 備註 { get; set; }

    public string inspectors_Name_Cooked { get; set; } = null!;

    public string? 熟食_承辦人員姓名 { get; set; }

    public string? 熟食_審查人員姓名 { get; set; }

    public string inspectors_Name_Oil { get; set; } = null!;

    public string? 油炸油_承辦人員姓名 { get; set; }

    public string? 油炸油_審查人員姓名 { get; set; }

    public string inspectors_Name_DISPOSE { get; set; } = null!;

    public string? undertakers_Name_DISPOSE { get; set; }

    public string? reviewers_Name_DISPOSE { get; set; }

    public string? reviewers_Name_Label { get; set; }

    public string inspectors_Name_Label { get; set; } = null!;

    public string? undertakers_Name_Label { get; set; }

    public string? COOK_status { get; set; }

    public string? OIL_status { get; set; }

    public string? DISPOSE_status { get; set; }

    public string? LABEL_status { get; set; }

    public DateOnly? 物品製造日期 { get; set; }

    public DateOnly? 物品有效日期 { get; set; }

    public string? CloseCooked { get; set; }

    public string? CloseOil { get; set; }

    public string? CloseDispose { get; set; }

    public string? CloseIllegal { get; set; }

    public string? SUPPLIER_NoShow { get; set; }

    public string? Manufacturers_NoShow { get; set; }

    public int? 物品包裝代碼 { get; set; }

    public string? 會同單位 { get; set; }

    public int? 標示_查驗類型編號 { get; set; }

    public string? 原料原產地 { get; set; }

    public string? 業者登錄字號 { get; set; }
}
