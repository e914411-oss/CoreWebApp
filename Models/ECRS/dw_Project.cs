using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Project
{
    public int ProjectId { get; set; }

    public string? DptCode { get; set; }

    public string? ProjectYear { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectType_GHP { get; set; }

    public string? ProjectType_Label { get; set; }

    public string? ProjectType_DISPOSE { get; set; }

    public string? ProjectType_COOK { get; set; }

    public DateTime? Create_Time { get; set; }

    public string? Create_Usrid { get; set; }

    public string? Layer { get; set; }

    public string? ProjectType_DISPOSE_Oil { get; set; }

    public string? ProjectType_HACCP { get; set; }

    public string? ProjectType_IRF { get; set; }

    public string? ProjectType_IRP { get; set; }

    public DateTime? MODDATE { get; set; }

    public string? TPEPK { get; set; }

    public string? ModUser { get; set; }

    public string? ProjectType_GHP_PE { get; set; }

    public string? ProjectType_IRF_Additives { get; set; }

    public string? ProjectType_IRF_Vitamins { get; set; }

    public string? ProjectType_IRP_Additives { get; set; }

    public string? ProjectType_IRP_MIT { get; set; }

    public string? ProjectType_IRP_Import { get; set; }

    public string? ProjectType_IRP_Patient { get; set; }

    public string? ProjectType_IRP_Baby { get; set; }

    public string? Active { get; set; }

    public string? ProjectType_VPF { get; set; }

    public string? ProjectType_Label_CF { get; set; }

    public string? Project_Operator { get; set; }

    public string? Project_Goal { get; set; }

    public string? Dynamic_Field { get; set; }
}
