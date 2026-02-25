using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核內容紀錄表
{
    public int 主鍵 { get; set; }

    public int 登錄查核主檔主鍵 { get; set; }

    public string? 登錄查核內容主類主鍵 { get; set; }

    public string? 登錄查核內容次類主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
