using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_抽驗違規明細
{
    public string? ORG { get; set; }

    public int 稽查主檔編號 { get; set; }

    public string? Signboard_Name { get; set; }

    public string? B_Main_ID { get; set; }

    public string? B_Sub_ID { get; set; }

    public string? Project_Names { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string Business_Address { get; set; } = null!;

    public string? ContractorsName { get; set; }

    public string? InspectorsName { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商地址 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 產品別主分類名稱 { get; set; }

    public string? 產品別次分類名稱 { get; set; }

    public string? 產品別細分類名稱 { get; set; }

    public int 物品稽查編號 { get; set; }

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

    public string? 物品編號 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗項目細類別名稱 { get; set; }

    public string? RVALUE { get; set; }

    public int FMS_FOODLAB_Id { get; set; }

    public string? LEGAL { get; set; }

    public string? 檢驗系統結果判定 { get; set; }

    public int IdxId { get; set; }

    public string? Undertake_Name { get; set; }

    public string? IdxName { get; set; }

    public int Industry_ID { get; set; }

    public string? 結案狀態 { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Main_Name { get; set; }

    public string? Sub_Name { get; set; }

    public string? Main_ID { get; set; }

    public string? Sub_ID { get; set; }

    public string? Business_Category_GroupbyIndustry_Classification { get; set; }

    public string? Rechk { get; set; }

    public string? Inspectors_Name { get; set; }

    public string? 專案編號 { get; set; }

    public string? External_Key { get; set; }

    public string? 承辦人員姓名 { get; set; }

    public string? 審查人員姓名 { get; set; }

    public string? status { get; set; }

    public string? 結案日期 { get; set; }

    public string? 食品地區別 { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? 產品認證TQF { get; set; }

    public string? 產品認證CAS { get; set; }

    public string? 產品認證TAP { get; set; }

    public string? 產品認證OTAP { get; set; }

    public string? 產品認證UTAP { get; set; }

    public string? 產品認證_有機認證 { get; set; }

    public string? 產品認證其他 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? INSP_Test_Item_Code { get; set; }

    public string? INSP_Test_Component_Code { get; set; }

    public string? INSP_Test_Item_Name { get; set; }

    public string? INSP_Test_Component_Name { get; set; }

    public string 檢驗結果來源 { get; set; } = null!;

    public DateOnly? 檢驗結果報告日期 { get; set; }
}
