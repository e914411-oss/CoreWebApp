using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行貨品明細表_20250226
{
    public decimal 主鍵 { get; set; }

    public DateTime? 資料寫入日期 { get; set; }

    public string? 報驗案號 { get; set; }

    public string? 貨品分類號列 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 產品英文名稱 { get; set; }

    public string? 規格 { get; set; }

    public string? 產地代碼 { get; set; }

    public string? 產地名稱 { get; set; }

    public double? 內裝數量 { get; set; }

    public string? 內裝數量單位 { get; set; }

    public decimal? 報單數量 { get; set; }

    public string? 報單數量單位 { get; set; }

    public string? IFI系統PK { get; set; }
}
