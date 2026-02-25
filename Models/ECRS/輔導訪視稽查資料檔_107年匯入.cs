using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視稽查資料檔_107年匯入
{
    public int 系統流水號 { get; set; }

    public int 輔導訪視業者編號 { get; set; }

    public int 稽查序號 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 稽查項目 { get; set; }

    public int? 稽查項目編號 { get; set; }

    public string? 稽查結果 { get; set; }
}
