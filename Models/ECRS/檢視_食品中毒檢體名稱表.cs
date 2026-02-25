using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒檢體名稱表
{
    public int 食品中毒檢體名稱表_代碼 { get; set; }

    public int? 食品中毒檢體類別_編號 { get; set; }

    public string? 食品中毒檢體名稱 { get; set; }

    public string 是否啟用 { get; set; } = null!;

    public int 排序 { get; set; }

    public DateTime? 創建時間 { get; set; }

    public string? 創建人員 { get; set; }

    public DateTime? 最後異動時間 { get; set; }

    public string? 最後異動人員 { get; set; }
}
