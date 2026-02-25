using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視資料檔_107年匯入
{
    public int 系統編號 { get; set; }

    public int? 輔導訪視業者編號 { get; set; }

    public int 訪視年度_民國 { get; set; }

    public int? 年度第幾次輔導 { get; set; }

    public string? 工廠登錄字號 { get; set; }

    public string? 工廠_製造場所名稱 { get; set; }

    public string? 工廠地址 { get; set; }

    public string? 類別 { get; set; }

    public string? 業別 { get; set; }

    public double? 資本額_元 { get; set; }

    public string? 輔導單位 { get; set; }

    public DateOnly? 輔導日期 { get; set; }

    public string? 輔導項目 { get; set; }

    public string? 輔導結果 { get; set; }

    public string? 等級 { get; set; }

    public string? 備註 { get; set; }

    public string? 來源 { get; set; }

    public DateTime? 匯入更新日期 { get; set; }
}
