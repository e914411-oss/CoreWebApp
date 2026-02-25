using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 教育部學校統編及代碼對應表
{
    public int 系統編號 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 學校統編 { get; set; }

    public string? 學校名稱 { get; set; }

    public string? 學校代碼 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
