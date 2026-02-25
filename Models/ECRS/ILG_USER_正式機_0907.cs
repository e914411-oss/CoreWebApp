using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class ILG_USER_正式機_0907
{
    public string UserId { get; set; } = null!;

    public string UserAccount { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string AccountStatus { get; set; } = null!;

    public DateTime? PasswordDeadline { get; set; }

    public string UserName { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string ID { get; set; } = null!;

    public string PhoneNo_O { get; set; } = null!;

    public string? PhoneNo_M { get; set; }

    public string Email { get; set; } = null!;

    public string DeleteMark { get; set; } = null!;

    public string CreateId { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public string UpdateId { get; set; } = null!;

    public DateTime UpdateTime { get; set; }

    public string RoleID { get; set; } = null!;

    public int? SortLocation { get; set; }
}
