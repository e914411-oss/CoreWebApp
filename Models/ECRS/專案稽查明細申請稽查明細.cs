using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案稽查明細申請稽查明細
{
    public int 申請明細編號 { get; set; }

    public int? 申請單編號 { get; set; }

    public int? 稽查項目編號 { get; set; }

    public string? 稽查項目名稱 { get; set; }

    public DateTime? 建立時間 { get; set; }
}
