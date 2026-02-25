using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vPMDS案件檢驗項目
{
    public string PMDS送驗單號 { get; set; } = null!;

    public string PMDS案件編號 { get; set; } = null!;

    public int PMDS檢體編號 { get; set; }

    public string? INSP案號 { get; set; }

    public string? INSP檢體編號 { get; set; }

    public int 檢驗項目序號 { get; set; }

    public string? 檢驗項目代碼 { get; set; }

    public string? 檢驗項目名稱 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 檢驗值 { get; set; }

    public string? 檢驗值單位 { get; set; }

    public string 檢驗結果判定 { get; set; } = null!;

    public string? 不合格原因 { get; set; }

    public string? 送驗字號 { get; set; }

    public DateOnly? 送驗日期 { get; set; }
}
