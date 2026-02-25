using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_idx_Industry_new
{
    public string? External_Key { get; set; }

    public int Industry_ID { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string Show_Business_Address { get; set; } = null!;

    public string? Business_Address { get; set; }

    public string? Company_Name { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Business_Category_Main_Id { get; set; }

    public string? Business_Category_Sub_Id { get; set; }

    public string? Business_Category_Main_Name { get; set; }

    public string? Business_Category_Sub_Name { get; set; }

    public string? Business_Category_Full_Name { get; set; }

    public DateTime? Create_Time { get; set; }

    public string? Expr1 { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public string? Business_Reg_ID { get; set; }

    public string Show_Reg_Address { get; set; } = null!;

    public string? Businuess_Status_Type_Show { get; set; }

    public string Cook_Licenses_Show { get; set; } = null!;

    public string? FAX { get; set; }

    public string? Chef_Licenses_Number { get; set; }

    public string? Cook_Licenses_C { get; set; }

    public string? Cook_Licenses_B { get; set; }

    public string? Employee_Number { get; set; }

    public string? Businuess_Status_Type_ID { get; set; }

    public string? NCHKDATE { get; set; }

    public string? DELFLAG { get; set; }

    public string? CookNum { get; set; }

    public string PermitteePCT { get; set; } = null!;

    public string? Remark { get; set; }

    public string? ManuallyReason { get; set; }

    public string? RegNum { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 資料轉入來源 { get; set; }

    public string? Faden_Type_Name { get; set; }

    public string? Faden_Category_Main_Name { get; set; }

    public string? Faden_Category_Sub_Name { get; set; }

    public string? Faden_Category_Det_Name { get; set; }

    public string? Faden_Category_Content { get; set; }
}
