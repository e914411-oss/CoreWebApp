using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 農委會_檢出項目與檢驗成分對照表_
{
    public int 系統編號 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗成分代碼 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 修改時間 { get; set; }
}
