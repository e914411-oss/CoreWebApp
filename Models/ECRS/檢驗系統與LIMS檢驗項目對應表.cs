using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統與LIMS檢驗項目對應表
{
    public int 系統編號 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗系統_檢驗項目編號 { get; set; }

    public string? 檢驗系統_檢驗成分編號 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
