using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 結案資料修改歷程記錄
{
    public int 歷程記錄編號 { get; set; }

    public int 稽查項目編號 { get; set; }

    public string 稽查項目中文 { get; set; } = null!;

    public int 稽查事件編號 { get; set; }

    public int 各稽查項目對應系統編號 { get; set; }

    public string? 修改原因 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime 修改時間 { get; set; }

    public string? 修改內容 { get; set; }
}
