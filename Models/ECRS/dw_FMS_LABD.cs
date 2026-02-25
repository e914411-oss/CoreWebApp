using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_FMS_LABD
{
    public string 檢驗項目主類別編號 { get; set; } = null!;

    public string 檢驗項目次類別編號 { get; set; } = null!;

    public string 檢驗項目次類別名稱 { get; set; } = null!;

    public string 是否停用 { get; set; } = null!;

    public int 流水編號 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員編號 { get; set; }
}
