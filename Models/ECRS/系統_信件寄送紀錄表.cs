using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_信件寄送紀錄表
{
    public int 主鍵 { get; set; }

    public string? 狀態 { get; set; }

    public string? 錯誤訊息 { get; set; }

    public DateTime? 日期 { get; set; }

    public string? 類型 { get; set; }
}
