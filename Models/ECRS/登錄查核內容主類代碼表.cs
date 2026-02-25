using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核內容主類代碼表
{
    public string 主鍵 { get; set; } = null!;

    public string? 主類項目 { get; set; }

    public string? 是否啟用 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
