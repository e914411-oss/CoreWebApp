using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_ICD類別主類
{
    public int ICD主類編號 { get; set; }

    public string? 章節 { get; set; }

    public string? 中文類別名稱 { get; set; }

    public string? 英文類別名稱 { get; set; }

    public string? 範圍 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
