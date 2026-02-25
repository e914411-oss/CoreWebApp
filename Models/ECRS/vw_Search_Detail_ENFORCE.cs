using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Search_Detail_ENFORCE
{
    public int Enforce_Main_ID { get; set; }

    public int? Check_List_ID { get; set; }

    public string? ORG { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? PROJECTS_IDs { get; set; }

    public string? PROJECTS_Names { get; set; }

    public string? Business_Category { get; set; }

    public string? Last_CheckDate { get; set; }

    public string? Is_FoodSafePlanType { get; set; }

    public string? Is_FoodSafePlan { get; set; }

    public string? Is_LaboratoryType { get; set; }

    public string? Is_Laboratory { get; set; }

    public string? RES1 { get; set; }

    public string? RES2 { get; set; }

    public string? RES3 { get; set; }

    public string? RES4 { get; set; }

    public string? RES5 { get; set; }

    public string? RES6 { get; set; }

    public string? RES7 { get; set; }

    public string? RES7_TYPE { get; set; }

    public string? RES8 { get; set; }

    public string? RES9 { get; set; }

    public string? RES10 { get; set; }

    public string? RES11 { get; set; }

    public string? RES12 { get; set; }

    public string? RESALL { get; set; }

    public string? RESALL_ID { get; set; }

    public string? CHKMAN { get; set; }

    public string? FMAN { get; set; }

    public string? AUDMAN { get; set; }

    public string? SENDCHK { get; set; }

    public string? FINISHED { get; set; }

    public string? FDATE { get; set; }

    public string? PRODUCT_INSURANCE { get; set; }

    public DateOnly? INSURANCE_SDATE { get; set; }

    public DateOnly? INSURANCE_EDATE { get; set; }

    public string? INSURANCE_SDATE_ROC { get; set; }

    public string? INSURANCE_EDATE_ROC { get; set; }

    public string? status { get; set; }

    public string? operatorID { get; set; }

    public string? RawHygiene_07_01 { get; set; }

    public string? RawHygiene_07_02 { get; set; }

    public string? RawHygiene_07_03 { get; set; }

    public string? Punish_Prosecute { get; set; }

    public string? Punish_Improve { get; set; }

    public DateOnly? Punish_Improve_Date { get; set; }

    public string? Punish_Outcounty { get; set; }

    public string? Punish_Destruction { get; set; }

    public string? Punish_RepealInd { get; set; }

    public string? Punish_ProductKeep { get; set; }

    public string? Punish_RepealLicense { get; set; }

    public string? Punish_CloseBusiness { get; set; }

    public string? Punish_AdminSanction { get; set; }

    public string? Punish_TerminateBusiness { get; set; }

    public DateOnly? Outcity_Doc_Date { get; set; }

    public string? Outcity_Doc_Number { get; set; }

    public string? Outcity_Outcounty { get; set; }

    public string? Outcity_Industry { get; set; }

    public string? Outcity_Owner { get; set; }

    public string? Outcity_Address { get; set; }

    public string? Outcity_Reason { get; set; }

    public string? Remark { get; set; }

    public int? RECHK_ID { get; set; }

    public string? TPEPK { get; set; }

    public string? TPEPK_First { get; set; }

    public string? TPEPK_Previous { get; set; }

    public string? ModUser { get; set; }

    public DateTime? MODDATE { get; set; }

    public string? 是否應實施強制性檢驗之類別及規模 { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_city_ID { get; set; }

    public string? City_Name { get; set; }

    public string? Business_County_ID { get; set; }

    public string? County_Name { get; set; }

    public string Business_Address { get; set; } = null!;

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? External_Key { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public int? Industry_ID { get; set; }

    public string? Company_Name { get; set; }

    public string? Industry_RegNum { get; set; }

    public string? Main_Name { get; set; }

    public string? Sub_Name { get; set; }

    public string? Sub_ID { get; set; }

    public string? Main_ID { get; set; }

    public string? External_Key_CL { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 強制檢驗是否符合 { get; set; }

    public string? 強制檢驗不符合項目 { get; set; }

    public string? 訂定食品安全監測計劃是否符合 { get; set; }

    public string? 設置實驗室是否符合 { get; set; }

    public string? 承辦意見 { get; set; }
}
