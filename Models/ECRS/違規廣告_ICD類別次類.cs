using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_ICD類別次類
{
    public int ICD次類編號 { get; set; }

    public int? ICD主類編號 { get; set; }

    public string? 次類代碼 { get; set; }

    public string? 中文次類別名稱 { get; set; }

    public string? 英文次類別名稱 { get; set; }

    public string? ICD報表名稱 { get; set; }

    public string? 是否納入報表統計 { get; set; }

    public int? 報表排序 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
