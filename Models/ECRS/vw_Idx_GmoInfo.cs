using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Idx_GmoInfo
{
    public int idx { get; set; }

    public string sno { get; set; } = null!;

    public string? category { get; set; }

    public string product_name { get; set; } = null!;

    public string breed { get; set; } = null!;

    public string? apply_name { get; set; }

    public DateTime approvetime { get; set; }

    public DateTime validtime { get; set; }

    public string? approvetime_Idx { get; set; }

    public string? validtime_Idx { get; set; }

    public string? approvetime_Show { get; set; }

    public string? validtime_Show { get; set; }

    public short product_type { get; set; }

    public DateTime createtime { get; set; }

    public short? location { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }
}
