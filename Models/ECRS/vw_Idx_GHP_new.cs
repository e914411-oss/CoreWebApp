using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Idx_GHP_new
{
    public int GHPREC_ID { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_Category_Main_ID { get; set; }

    public string? Business_Category_Main_Name { get; set; }

    public string? Business_Category_Sub_ID { get; set; }

    public string? Business_Category_Sub_Name { get; set; }

    public string? Address { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? RESALL { get; set; }

    public string? RESALL_ID { get; set; }

    public string? RES7_TYPE { get; set; }

    public string? ORG { get; set; }

    public string? Telephone { get; set; }

    public string? PROJECTS_IDs { get; set; }

    public string? PROJECTS_Names { get; set; }

    public DateOnly? DAYLINEDATE { get; set; }

    public int IdxId { get; set; }

    public string IdxName { get; set; } = null!;

    public int? Industry_ID { get; set; }

    public string? ContractorsName { get; set; }

    public string? InspectorsName { get; set; }

    public int? RECHK_ID { get; set; }

    public int? RECHK_NO { get; set; }

    public DateTime? RECHK_DATE { get; set; }
}
