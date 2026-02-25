using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_電台頻道主檔
{
    public int 電台編號 { get; set; }

    public string 電台名稱 { get; set; } = null!;

    public string 電台頻道 { get; set; } = null!;

    public string 電台頻率 { get; set; } = null!;

    public string? 狀態 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }
}
