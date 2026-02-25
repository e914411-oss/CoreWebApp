using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件刪除申請記錄
{
    public string 案件編號 { get; set; } = null!;

    public string? 刪除狀態 { get; set; }

    public string? 刪除原因 { get; set; }

    public string? 申請人員 { get; set; }

    public DateTime? 申請時間 { get; set; }

    public string? 審核人員 { get; set; }

    public DateTime? 審核時間 { get; set; }
}
