using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Promise_Discharged
{
    public int Promise_Discharged_ID { get; set; }

    public string? External_Key { get; set; }

    public string? Report_Case_ID { get; set; }

    public string? Company_Name { get; set; }

    public string? Promise_City { get; set; }

    public string? Promise_Address { get; set; }

    public string? Product_Name { get; set; }

    public string? Check_Results { get; set; }

    public DateTime? Admissibility_Date { get; set; }

    public string? ReportCase_Obligation_Person { get; set; }

    public string? Brand_Name { get; set; }

    public string? Import_Date { get; set; }

    public string? Declaration_No { get; set; }

    public string? Discharged_Date { get; set; }

    public string? Check_Date { get; set; }

    public string? Case_apply_Reasons { get; set; }

    public string? Contact_Person { get; set; }

    public string? ContactPerson_Email { get; set; }

    public string? ContactPerson_Tel { get; set; }

    public string? ContactPerson_Fax { get; set; }

    public string? ContactPerson_Phone { get; set; }

    public string? Promise_Date { get; set; }

    public string? StartShipment_Date { get; set; }

    public string? Arrival_Date { get; set; }

    public string? ScheduledDelivery_Date { get; set; }

    public string? Review_Results { get; set; }

    public string? Transaction_Person { get; set; }

    public string? Transaction_Date { get; set; }

    public string? Inspection_Results { get; set; }

    public string? Remark { get; set; }

    public string? Product_No { get; set; }

    public string? Product_Name_CN { get; set; }

    public string? Product_Specification { get; set; }

    public string? Product_Name_EN { get; set; }

    public string? Produce_Country { get; set; }

    public string? Interior_Count { get; set; }

    public string? Declaration_Count { get; set; }

    public int Promise_Discharged_Product_ID { get; set; }

    public int? CN_Len { get; set; }
}
