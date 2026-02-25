using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者與非登業別同步資料檔
{
    public int 系統編號 { get; set; }

    public int? 業者編號 { get; set; }

    public string? 非登業者業別 { get; set; }

    public string? 非登業者業別代碼 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public DateTime? 更新日期 { get; set; }
}
