using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Poisoned
{
    public int Case_ID { get; set; }

    public int? External_Key { get; set; }

    public string? Case_City_Code { get; set; }

    public string? Case_City_Name { get; set; }

    public DateTime? Report_Date { get; set; }

    public string? Report_Date_ROC { get; set; }

    public string? Report_Date_ROC_Time { get; set; }

    public string? Report_Unit { get; set; }

    public DateTime? Case_Process_Date { get; set; }

    public string? Case_Process_Date_ROC { get; set; }

    public string? Case_Process_Date_ROC_Time { get; set; }

    public string? Case_Summ_Description { get; set; }

    public int? Case_Total_Poison { get; set; }

    public int? Case_Total_Eaten { get; set; }

    public int? Case_Total_Dead { get; set; }

    public DateTime? Case_Sick_Date { get; set; }

    public string? Case_Sick_Date_ROC { get; set; }

    public string? Case_Sick_Date_ROC_Time { get; set; }

    public string? Case_Sick_Place { get; set; }

    public string? Case_Min_Bef_Sick_HH { get; set; }

    public string? Case_Min_Bef_Sick_MM { get; set; }

    public string? Case_Max_Bef_Sick_HH { get; set; }

    public string? Case_Max_Bef_Sick_MM { get; set; }

    public string? Pred_Poison_RCode_1 { get; set; }

    public string? Pred_Poison_RCode_1_1 { get; set; }

    public string? Pred_Poison_RCode_2 { get; set; }

    public string? Pred_Poison_RCode_2_1 { get; set; }

    public string? Pred_Poison_RCode_2_2 { get; set; }

    public string? Pred_Poison_RCode_2_3 { get; set; }

    public string? Pred_Poison_RCode_2_4 { get; set; }

    public string? Pred_Poison_RText_2_4 { get; set; }

    public string? Pred_Poison_RCode_3 { get; set; }

    public string? Pred_Poison_RCode_3_1 { get; set; }

    public string? Pred_Poison_RText_3_1 { get; set; }

    public string? Pred_Poison_RCode_3_2 { get; set; }

    public string? Pred_Poison_RText_3_2 { get; set; }

    public string? Pred_Poison_RCode_3_3 { get; set; }

    public string? Pred_Poison_RText_3_3 { get; set; }

    public string? Pred_Poison_RCode_4 { get; set; }

    public string? Pred_Poison_RText_4 { get; set; }

    public string? Pred_Poison_RCode_5 { get; set; }

    public string? Pred_Poison_RText_5 { get; set; }

    public string? Food_Poison_RCode_13 { get; set; }

    public string? Food_Poison_RText_13 { get; set; }

    public string? Food_Process_Code { get; set; }

    public string? Food_Pre_Preserve_Time { get; set; }

    public int? Food_Pre_Preserve_Tmpt { get; set; }

    public string? Food_Pre_Receive_Time_HHMM { get; set; }

    public string? Food_Pre_Source_Process { get; set; }

    public string? Food_IDs { get; set; }

    public string? Symptom_IDs { get; set; }

    public string? Case_Detail_Description { get; set; }

    public string? Food_SamplesTesting { get; set; }

    public string? Remark { get; set; }

    public string? Del_MK { get; set; }

    public DateTime? Create_Time { get; set; }

    public DateTime? Update_Time { get; set; }

    public DateTime? Del_Time { get; set; }

    public DateTime? Submit_Time { get; set; }

    public int? Data_Status { get; set; }

    public string? IsPublish { get; set; }

    public string? Move_Out_MK { get; set; }

    public string? UsrUid { get; set; }

    public DateOnly? NCHKDATE { get; set; }

    public string? Docid { get; set; }

    public string? Docstate { get; set; }

    public string? Docclass { get; set; }

    public string? IsFoodinspection { get; set; }

    public string? MasterDocid { get; set; }

    public int? food_unknow { get; set; }

    public string? food_reason { get; set; }

    public int? Material_unknow { get; set; }

    public string? virusname { get; set; }

    public string? Material_Reason { get; set; }

    public string? Poisoned_Place { get; set; }

    public string? No_Specimen { get; set; }

    public int? PublishCount { get; set; }

    public int? Case_Total_Hospital { get; set; }

    public string? SupplyIsEatPlace { get; set; }

    public string? Ori_Case_City_Code { get; set; }

    public string? 填報人員 { get; set; }

    public int? 是否為網購食品 { get; set; }
}
