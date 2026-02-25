using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_非登不可_食品業者主動通報_For非登
{
    public int PMDS系統編號 { get; set; }

    public int? 通報案件編號 { get; set; }

    public string? PMDS案件狀態 { get; set; }
}
