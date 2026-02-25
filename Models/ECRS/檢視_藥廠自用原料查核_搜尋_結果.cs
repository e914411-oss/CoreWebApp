using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_藥廠自用原料查核_搜尋_結果
{
    public int 藥廠自用原料查核通報主表 { get; set; }

    public int? 稽查序號 { get; set; }

    public string? 查核結果_報關文件相符 { get; set; }

    public string? 查核結果_資訊相符 { get; set; }

    public int? 查核結果_實際進口量 { get; set; }

    public DateTime? 查核結果_進口時間 { get; set; }

    public string? 查核結果_原料原廠批號 { get; set; }

    public int? 查核結果_入庫數量 { get; set; }

    public DateTime? 查核結果_入庫時間 { get; set; }

    public int? 查核結果_原料剩餘數量 { get; set; }

    public string? 查核結果_入庫量相符 { get; set; }

    public string? 查核結果_入庫時間是否合理 { get; set; }

    public string? 查核結果_是否提出解釋及切結書 { get; set; }

    public DateOnly? 查核結果_處分時間 { get; set; }

    public string? 查核結果_缺失說明 { get; set; }

    public string? 查核結果_其他說明 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public DateOnly? 處分情形_限期改善日期 { get; set; }

    public string? 處理情形_禁止出售 { get; set; }

    public string? 處理情形_其他 { get; set; }

    public string? 處理情形_其他說明 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市主鍵 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 備註說明 { get; set; }

    public int? 藥廠自用原料查核專案名稱主鍵 { get; set; }

    public int? 專案明細主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public string? External_Key { get; set; }

    public string? ORG { get; set; }

    public int? Industry_ID { get; set; }

    public string? External_Key_Industry_ID { get; set; }

    public string? BMT_NO { get; set; }

    public string? PJNO { get; set; }

    public string? PJNO_Show { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? CHKTime_ROC { get; set; }

    public string? DAYLINE { get; set; }

    public DateOnly? DAYLINEDATE { get; set; }

    public string? RECHK { get; set; }

    public DateOnly? RECHKDATE { get; set; }

    public string? RECHKDATE_ROC { get; set; }

    public string? ASSDATE { get; set; }

    public string? SENDCHK { get; set; }

    public string? CHKSCR { get; set; }

    public string? CHKEDMAN { get; set; }

    public string? Collaboration_IDs { get; set; }

    public string? Contractors { get; set; }

    public DateTime? Create_Time { get; set; }

    public DateTime? Update_Time { get; set; }

    public string? MODDATE { get; set; }

    public DateTime? Submit_Time { get; set; }

    public int? Data_Status { get; set; }

    public string? Create_ID { get; set; }

    public string? DELFLAG { get; set; }

    public string? Del_MK { get; set; }

    public int? Sort { get; set; }

    public DateOnly? FDate { get; set; }

    public string? FDate_ROC { get; set; }

    public string? TEXTNO { get; set; }

    public string? IsFromPCO { get; set; }

    public int? RECHK_ID { get; set; }

    public int? RECHK_NO { get; set; }

    public int? RECHK_ORI { get; set; }

    public bool? fromPoison { get; set; }

    public string? IsPoisoned { get; set; }

    public string? External_Key_Haccp_Key { get; set; }

    public string? TPEPK { get; set; }

    public string? ModUser { get; set; }

    public string? TPECHKNO { get; set; }

    public string? IsAPPCreate { get; set; }

    public int 派案_自用源料查核資訊表 { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 醫事機構代碼 { get; set; }

    public DateTime? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 自用源料申請商 { get; set; }

    public string? 原料藥品名稱 { get; set; }

    public string? 使用該原料藥之製造商名稱 { get; set; }

    public string? 供製造藥品之許可證字號 { get; set; }

    public string? 供製造藥品之中文品名 { get; set; }

    public int? 申請進口數量 { get; set; }

    public int? 季別 { get; set; }

    public string? 原料藥製造廠國名 { get; set; }

    public string? 原料藥製造廠名稱 { get; set; }

    public string? 原料藥製造廠地址_縣市 { get; set; }

    public string? 原料藥製造廠地址_區域 { get; set; }

    public string? 原料藥製造廠地址_地址 { get; set; }

    public string? 派案登記桌主鍵 { get; set; }

    public string? 稽查人員ID { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Company_Name { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Business_Reg_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? Business_Address { get; set; }

    public string? Reg_City_ID { get; set; }

    public string? Reg_County_ID { get; set; }

    public string? Reg_Address { get; set; }

    public string? Telephone { get; set; }

    public string? FAX { get; set; }

    public string? Businuess_Status_Type_ID { get; set; }

    public string? Chef_Licenses_Number { get; set; }

    public string? Cook_Licenses_C { get; set; }

    public string? Cook_Licenses_B { get; set; }

    public string? Employee_Number { get; set; }

    public string? Cook_Licenses_HACCP { get; set; }

    public string? Cook_Licenses_GMP { get; set; }

    public string? Cook_Licenses_GSP { get; set; }

    public string? Cook_Licenses_CAS { get; set; }

    public string? Cook_Licenses_Other { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Mobile_Phone { get; set; }

    public string? EMail { get; set; }

    public string? Residence_Address_City_ID { get; set; }

    public string? Residence_Address_County_ID { get; set; }

    public string? Residence_Address { get; set; }

    public string? Correspondence_Address_City_ID { get; set; }

    public string? Correspondence_Address_County_ID { get; set; }

    public string? Correspondence_Address { get; set; }

    public string? Food_Health_Manager { get; set; }

    public string? Food_Health_Responsible { get; set; }

    public string? Water_Type_ID { get; set; }

    public string? Water_Type_City_ID { get; set; }

    public string? Water_Type_County_ID { get; set; }

    public string? Water_Type_Address { get; set; }

    public string? Water_Name { get; set; }

    public DateTime? Water_Date { get; set; }

    public string? Water_ROC_Date { get; set; }
}
