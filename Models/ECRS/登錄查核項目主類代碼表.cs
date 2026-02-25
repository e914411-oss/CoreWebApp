using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核項目主類代碼表
{
    public int 主鍵 { get; set; }

    public string? 登錄查核項目主類名稱 { get; set; }

    public string? 登錄查核內容主類主鍵 { get; set; }

    public string? 登錄查核內容次類主鍵 { get; set; }

    public string? 是否啟用 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
