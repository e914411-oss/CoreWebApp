using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品標示稽查條文表
{
    public Guid 物品標示編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public int 查驗條文編號 { get; set; }

    public string 查核結果 { get; set; } = null!;

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
