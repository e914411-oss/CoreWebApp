using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_INSP_Violation
{
    public int 案件編號 { get; set; }

    public string FDA發文字號 { get; set; } = null!;

    public string? 產品品名 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 違反法條 { get; set; }

    public string? 後續核處情形 { get; set; }
}
