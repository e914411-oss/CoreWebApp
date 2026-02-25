using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Idx_CheckRec
{
    public int Check_List_ID { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? SENDCHK { get; set; }

    public string? FINISHED { get; set; }

    public string? 專案名稱編號 { get; set; }

    public string? Check_List_EKey { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Industry_EKey { get; set; }

    public string? Business_Category { get; set; }

    public string? Business_Category_Sub_Id { get; set; }

    public DateOnly? FDate { get; set; }

    public DateOnly? RECHKDATE { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CheckType { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Business_Category_Sub_Name { get; set; }

    public string? Business_Category_Main_Name { get; set; }

    public string? RECHKType { get; set; }

    public int? Industry_ID { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }

    public string? RESALL { get; set; }

    public string? Inspectors_Name { get; set; }

    public string? CHKDATE_Show { get; set; }

    public string? ContractorsName { get; set; }

    public string? InspectorsName { get; set; }

    public string? External_Key_Haccp_Key { get; set; }

    public string? External_Key { get; set; }

    public int? GHPREC_ID { get; set; }

    public int? IRF_ID { get; set; }

    public string? Inspector { get; set; }

    public string? ORG { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 中毒案件編號 { get; set; }

    public string? Del_MK { get; set; }

    public int? 化粧品工廠稽查主表主鍵 { get; set; }

    public int? 瘦身美容業稽查主表主鍵 { get; set; }

    public int? 藥商_藥局_醫療機構稽查主表主鍵 { get; set; }

    public int? 化粧品業者稽查主檔ID { get; set; }
}
