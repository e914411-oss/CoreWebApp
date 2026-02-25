using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class AP_User1
{
    public string UsrUid { get; set; } = null!;

    public string? UsrName { get; set; }

    public string? UsrOtel { get; set; }

    public string? UsrOExt { get; set; }

    public string? DptCode { get; set; }

    public string? OU { get; set; }

    public string? Country { get; set; }

    public string? Pwd { get; set; }

    public string? Mobile { get; set; }

    public string? Mail { get; set; }

    public DateTime? Create_Time { get; set; }

    public DateTime? Upd_Time { get; set; }

    public string? PosName { get; set; }

    public string? TokenID { get; set; }

    public string? ApplySource { get; set; }

    public string? IsDel { get; set; }

    public string? ORGANIZATIONALCODE { get; set; }

    public int? IsNeedChgPwd { get; set; }

    public DateTime? LastChgPwdTime { get; set; }

    public string? LoginID { get; set; }

    public string? UserIdentity { get; set; }

    public string? User_Identity { get; set; }

    public string? Unit { get; set; }

    public int RoleId { get; set; }

    public string? after_usruid { get; set; }

    public bool? Is_Captain { get; set; }

    public string? Area { get; set; }

    public int? LoginErrorNum { get; set; }

    public DateTime? LoginLockTime { get; set; }

    public string? ILG_UserId { get; set; }

    public string? Sex { get; set; }

    public string? CreateUser { get; set; }

    public string? UpdateUser { get; set; }

    public string? ILG_RoleId { get; set; }

    public int? ILG_SortLocation { get; set; }

    public string? 移入案件派案登記桌權限 { get; set; }

    public string? 代施機構審核人權限 { get; set; }
}
