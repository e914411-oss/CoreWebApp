using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Project
{
    public int Id { get; set; }

    public string? CodeValue { get; set; }

    public string? CodeName { get; set; }

    public string? ProjectType_GHP { get; set; }

    public string? ProjectType_Label { get; set; }

    public string? ProjectType_DISPOSE { get; set; }

    public string? ProjectType_COOK { get; set; }

    public string? DptCode { get; set; }

    public string? ProjectType_HACCP { get; set; }

    public string? ProjectType_IRF { get; set; }

    public string? ProjectType_IRP { get; set; }

    public string? ProjectType_GHP_PE { get; set; }

    public string? ProjectType_IRF_Additives { get; set; }

    public string? ProjectType_IRP_Additives { get; set; }

    public string? ProjectType_IRF_Vitamins { get; set; }

    public string? ProjectType_IRP_MIT { get; set; }

    public string? ProjectType_IRP_Import { get; set; }

    public string? ProjectType_IRP_Patient { get; set; }

    public string? ProjectType_VPF { get; set; }

    public string? ProjectType_IRP_Baby { get; set; }

    public string? Active { get; set; }

    public string? ProjectYear { get; set; }

    public string? Project_Goal { get; set; }

    public string? Project_Operator { get; set; }

    public string? ProjectType_Label_CF { get; set; }

    public string? ModUser { get; set; }

    public string? TPEPK { get; set; }

    public DateTime? MODDATE { get; set; }

    public string? Layer { get; set; }

    public string? ProjectType_DISPOSE_Oil { get; set; }

    public string? Create_Usrid { get; set; }

    public DateTime? Create_Time { get; set; }

    public int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? DeptName { get; set; }

    public string? Dynamic_Field { get; set; }

    public string? ProjectType_COB { get; set; }

    public string? ProjectType_COF { get; set; }

    public string? ProjectType_COS { get; set; }

    public string? ProjectType_DRF { get; set; }

    public string? ProjectType_DRM { get; set; }

    public string? ProjectType_DRR { get; set; }

    public string? ProjectType_MDE { get; set; }

    public string? ProjectType_DRG { get; set; }

    public string? ProjectType_Reg { get; set; }

    public string? ProjectType_Trace { get; set; }

    public string? ProjectType_Enforce { get; set; }

    public string? ProjectType_FoodOrder { get; set; }

    public string? ProjectType_Voucher { get; set; }

    public string? ProjectType_Banquets { get; set; }

    public string? ProjectType_DRPR { get; set; }

    public string? ProjectType_MEDPR { get; set; }

    public string? ProjectType_COSPR { get; set; }

    public string? ProjectType_COSVender { get; set; }

    public string? ProjectType_Insurance { get; set; }

    public string? ProjectType_SourceDoc { get; set; }

    public string? ProjectType_ExpiredFood { get; set; }

    public string? ProjectType_HealthManager { get; set; }

    public string? ProjectType_ProTechCert { get; set; }
}
