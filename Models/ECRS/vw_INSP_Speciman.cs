using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_INSP_Speciman
{
    public string 送驗單號 { get; set; } = null!;

    public string? 檢體編號 { get; set; }

    public string 商號 { get; set; } = null!;

    public string 商號_地址 { get; set; } = null!;

    public string? 品名 { get; set; }

    public string? 劑型 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 批號 { get; set; }

    public string? 來源商 { get; set; }

    public string? 來源商地址 { get; set; }

    public string? 申請商 { get; set; }

    public string? 申請商地址 { get; set; }

    public string? 製造商 { get; set; }

    public string? 製造商地址 { get; set; }

    public DateOnly 製造日期 { get; set; }

    public DateOnly 失效日期 { get; set; }
}
