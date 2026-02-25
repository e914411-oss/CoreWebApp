using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHPREC
{
    public int GHPREC_ID { get; set; }

    public string? Business_Category { get; set; }

    public string? External_Key { get; set; }

    public int? Check_List_ID { get; set; }

    public string? ORG { get; set; }

    public DateOnly? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? PROJECTS_IDs { get; set; }

    public string? PROJECTS_Names { get; set; }

    public string? REALSCR { get; set; }

    public string? LIGHT_WTAB { get; set; }

    public string? LIGHT_CTAB { get; set; }

    public string? LIGHT_GEN { get; set; }

    public string? TEMP_COOL { get; set; }

    public string? TEMP_COLD { get; set; }

    public string? TEMP_HOT { get; set; }

    public string? FOOD_NORMAL { get; set; }

    public string? FOOD_ADD { get; set; }

    public string? FOOD_DETERGENTS { get; set; }

    public string? FOOD_CONTAINERS { get; set; }

    public string? FOOD_TOTAL { get; set; }

    public string? FOOD_PASSED { get; set; }

    public string? FOOD_FAILED { get; set; }

    public string? SELFMANG { get; set; }

    public string? SELFCHK { get; set; }

    public string? AUTHNUM { get; set; }

    public string? WORKERNUM { get; set; }

    public string? C { get; set; }

    public string? B { get; set; }

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

    public DateTime? MODDATE { get; set; }

    public string? MODDATE_ROC { get; set; }

    public string? status { get; set; }

    public string? operatorID { get; set; }

    public string? illegal { get; set; }

    public string? penalty { get; set; }

    public string? remark { get; set; }

    public string? stop { get; set; }

    public string? court { get; set; }

    public string? inspectors { get; set; }

    public string? undertakers { get; set; }

    public string? reviewers { get; set; }

    public string? closingDate { get; set; }

    public int? RECHK_ID { get; set; }

    public int? RECHK_NO { get; set; }

    public int? RECHK_ORI { get; set; }

    public string? Source_CHKMAN { get; set; }

    public string? Source_FMAN { get; set; }

    public string? Source_AUDMAN { get; set; }

    public string? memo { get; set; }

    public string? TPEPK { get; set; }

    public string? TPEPK_First { get; set; }

    public string? TPEPK_Previous { get; set; }

    public string? ModUser { get; set; }

    public string? Business_Category_Sub { get; set; }

    public string? CookerNum { get; set; }

    public string? PTNUM { get; set; }

    public string? United_Chk { get; set; }

    public string? FTNUM { get; set; }

    public string? FTPENUM { get; set; }

    public string? PTPENUM { get; set; }

    public string? illegal_raw13 { get; set; }

    public int? Label_CF_CKNUM { get; set; }

    public string? Label_CF_Result { get; set; }

    public string? Label_CF_NotOK_Situation { get; set; }

    public string? FoodAdd_Single { get; set; }

    public string? FoodAdd_Single_NotOK_Situation { get; set; }

    public string? FoodAdd_Double { get; set; }

    public string? FoodAdd_Double_NotOK_Situation { get; set; }

    public string? IsManufacturersImport { get; set; }

    public string? NotImportManufacturers { get; set; }

    public string? Label_CF_AfterTodoSituation { get; set; }

    public string? Label_CF_PD_Description { get; set; }

    public string? Visceral { get; set; }

    public string? Transport_SF { get; set; }

    public string? Driver_SF { get; set; }

    public string? Car_Id_SF { get; set; }

    public string? Transport_Result_SF { get; set; }

    public string? Transport_TF { get; set; }

    public string? Name_TF { get; set; }

    public string? Tel_TF { get; set; }

    public string? Driver_TF { get; set; }

    public string? Car_Id_TF { get; set; }

    public string? Address_TF { get; set; }

    public string? Transport_Result_TF { get; set; }

    public string? Transport_Other_Name { get; set; }

    public string? Transport_Other_Address { get; set; }

    public string? Transport_Other_Tel { get; set; }

    public string? Driver_Other { get; set; }

    public string? Car_Id_Other { get; set; }

    public string? Visceral_Remark { get; set; }

    public DateOnly? Create_Date { get; set; }

    public string? Is_Notification { get; set; }
}
