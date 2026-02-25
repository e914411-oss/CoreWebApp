using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行申請運往地點表_20250226
{
    public decimal 主鍵 { get; set; }

    public DateTime? 資料寫入日期 { get; set; }

    public string? 報驗案號 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 縣市名 { get; set; }

    public string? 地址 { get; set; }

    public decimal? 金額 { get; set; }

    public string? 金額單位 { get; set; }

    public string? 國曆回報日期 { get; set; }

    public string? 回報結果代碼 { get; set; }

    public string? 回報結果 { get; set; }

    public string? 國曆通報日期 { get; set; }

    public string? 備註 { get; set; }

    public string? IFI系統PK { get; set; }

    public string? 縣市代碼_PMDS { get; set; }

    public string? 縣市名_PMDS { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 狀態 { get; set; }

    public string? 稽查時間_時 { get; set; }

    public string? 稽查時間_分 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public string? 封存情形回報 { get; set; }

    public string? 封存情形回報_日期 { get; set; }

    public string? 封存情形回報_備註 { get; set; }

    public string? 銷毀退運情形回報 { get; set; }

    public string? 銷毀退運情形回報_日期 { get; set; }

    public string? 銷毀退運情形回報_備註 { get; set; }

    public decimal? IFI系統主表PK { get; set; }

    public string? 已稽查不符合規定子結果 { get; set; }
}
