using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_輔導紀錄查詢
{
    public int? 訪視年度_民國 { get; set; }

    public int 輔導訪視業者編號 { get; set; }

    public string? 輔導項目 { get; set; }

    public double? 資本額_元 { get; set; }

    public string? 工廠_製造場所名稱 { get; set; }

    public string? 業別 { get; set; }

    public string? 工廠登錄字號 { get; set; }

    public string? 工廠地址 { get; set; }

    public int? 輔導次數 { get; set; }

    public int? 驗證次數 { get; set; }

    public int? 稽查次數 { get; set; }
}
