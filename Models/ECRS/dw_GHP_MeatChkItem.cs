using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_GHP_MeatChkItem
{
    public int MeatChkItemID { get; set; }

    public string MeatChkItemText { get; set; } = null!;

    public string IsActive { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public DateTime? ModDate { get; set; }

    public string? CreateUser { get; set; }

    public string? ModUser { get; set; }

    public string? Sort { get; set; }
}
