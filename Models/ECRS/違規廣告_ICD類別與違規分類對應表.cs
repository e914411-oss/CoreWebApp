using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_ICD類別與違規分類對應表
{
    public int 對應編號 { get; set; }

    public int ICD次類編號 { get; set; }

    public int? 違規分類代碼流水號 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }
}
