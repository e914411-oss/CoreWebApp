using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Industry
{
    public int Industry_ID { get; set; }

    public string? External_Key { get; set; }

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

    public string? Remark { get; set; }

    public string? Water_Type_ID { get; set; }

    public string? Water_Type_City_ID { get; set; }

    public string? Water_Type_County_ID { get; set; }

    public string? Water_Type_Address { get; set; }

    public string? Water_Name { get; set; }

    public DateTime? Water_Date { get; set; }

    public string? Water_ROC_Date { get; set; }

    public string? ModUserNane { get; set; }

    public DateTime? Update_Time { get; set; }

    public DateTime? Create_Time { get; set; }

    public string? Create_ROC_Time { get; set; }

    public string? Create_ID { get; set; }

    public string? ORG { get; set; }

    public string? CRTORG { get; set; }

    public DateTime? Submit_Time { get; set; }

    public int? Data_Status { get; set; }

    public string? NCHKDATE { get; set; }

    public string? ModUserID { get; set; }

    public string? DELFLAG { get; set; }

    public string? ISplatform { get; set; }

    public string? ISHACCP { get; set; }

    public string? ISIRF { get; set; }

    public string? Food_Tech_Name { get; set; }

    public string? Food_Tech_Id { get; set; }

    public string? Health_Managemen_Name { get; set; }

    public string? Health_Tech_Name { get; set; }

    public string? Nutritionist { get; set; }

    public string? IS_HealthFactory { get; set; }

    public string? IS_HealthFactory_Del { get; set; }

    public string? HACCP_Industry { get; set; }

    public string? MAXPRODUCT_TX { get; set; }

    public string? IndustryState { get; set; }

    public string? TPEPK { get; set; }

    public string? CookNum { get; set; }

    public string? RegNum { get; set; }

    public string? Responsible_Person_ID { get; set; }

    public DateTime? GHP_CHKDATE { get; set; }

    public string? Del_User { get; set; }

    public DateTime? Del_Time { get; set; }

    public string? ManuallyReason { get; set; }
}
