using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Idx_CheckRec_new
{
    public int Check_List_ID { get; set; }

    public string? SENDCHK { get; set; }

    public string FINISHED { get; set; } = null!;

    public string? 專案名稱編號 { get; set; }

    public string? Check_List_EKey { get; set; }

    public DateOnly? FDate { get; set; }

    public DateOnly? RECHKDATE { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CheckType { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? RECHKType { get; set; }

    public int? Industry_ID { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }

    public string? RESALL { get; set; }

    public string? Inspectors_Name { get; set; }

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

    public int? 產品責任保險主鍵 { get; set; }

    public int? 來源文件保存主鍵 { get; set; }

    public int? 逾期食品主鍵 { get; set; }

    public int? 衛生管理人員查核主鍵 { get; set; }

    public int? 專門職業或技術證照人員查核主鍵 { get; set; }
}
