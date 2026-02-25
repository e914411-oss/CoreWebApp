using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class QMS與PMDS單位代碼對應表
{
    public int QMS單位代碼 { get; set; }

    public string QMS單位名稱 { get; set; } = null!;

    public string PMDS單位代碼 { get; set; } = null!;
}
