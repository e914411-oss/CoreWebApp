using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_專案資料
{
    public int 專案編號 { get; set; }

    public string? 建立縣市 { get; set; }

    public string? 專案年度 { get; set; }

    public string? 專案名稱 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 介面異動者 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateTime? 介面異動時間 { get; set; }
}
