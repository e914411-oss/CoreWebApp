using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP_Temp
{
    public int HACCP_ID { get; set; }

    public string? Business_Category { get; set; }

    public string? External_Key { get; set; }

    public int? Check_List_ID { get; set; }

    public string? ORG { get; set; }

    public DateOnly? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? PROJECTS_IDs { get; set; }

    public string? PROJECTS_Names { get; set; }

    public string? SELFMANG { get; set; }

    public string? SELFCHK { get; set; }

    public string? AUTHNUM { get; set; }

    public string? WORKERNUM { get; set; }

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

    public string? CHKMAN { get; set; }

    public string? FMAN { get; set; }

    public string? AUDMAN { get; set; }

    public string? SENDCHK { get; set; }

    public string? Closing_date { get; set; }

    public string? FINISHED { get; set; }

    public string? FDATE { get; set; }

    public string? PRODUCT_INSURANCE { get; set; }

    public DateTime? MODDATE { get; set; }

    public string? MODDATE_ROC { get; set; }

    public string? status { get; set; }

    public string? operatorID { get; set; }

    public string? FoodTechnicianName { get; set; }

    public string? TechnicianIdentificationNumber { get; set; }

    public string? HealthManagers { get; set; }

    public string? HealthProfessionals { get; set; }

    public string? Nutritionist { get; set; }

    public string? InspectionResult { get; set; }

    public string? InspectionResult_id { get; set; }

    public string? DeadlineImproved { get; set; }

    public string? Violation { get; set; }

    public string? ViolationOther { get; set; }

    public string? Announcement { get; set; }

    public string? Disposal_SuspendBusiness { get; set; }

    public string? Disposal_TransferredCourt { get; set; }

    public string? FineAmount { get; set; }

    public string? Remark { get; set; }

    public string? ViolationFSMA_20_1 { get; set; }

    public string? inspectors { get; set; }

    public string? inspectors_name { get; set; }

    public string? undertakers { get; set; }

    public string? undertakers_name { get; set; }

    public string? reviewers { get; set; }

    public string? reviewers_name { get; set; }

    public string? closingDate { get; set; }

    public int? RECHK_ID { get; set; }

    public int? RECHK_NO { get; set; }

    public string? RECHK_ORI { get; set; }

    public string? CHK_Type { get; set; }

    public string? HACCP_Industry { get; set; }
}
