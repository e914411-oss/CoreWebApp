using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_匯入國際警訊案件排程
{
    public int 流水號 { get; set; }

    public DateTime? 日期 { get; set; }

    public string? 狀態 { get; set; }

    public string? 失敗原因 { get; set; }

    public int? 案件筆數 { get; set; }
}
