using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 驗證系統資訊介接表
{
    public int 主鍵 { get; set; }

    public string? 登錄字號 { get; set; }

    public DateOnly? 驗證日期 { get; set; }

    public DateOnly? 驗證效期 { get; set; }

    public string? 驗證機構 { get; set; }

    public string? 驗證範圍 { get; set; }

    public string? 驗證人員 { get; set; }

    public string? 驗證說明書編號 { get; set; }

    public byte[]? 驗證報告 { get; set; }

    public string? 驗證名稱 { get; set; }
}
