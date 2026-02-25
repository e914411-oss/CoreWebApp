using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_FTR_申請運往地點表
{
    public DateTime? 資料寫入日期 { get; set; }

    public decimal 主鍵 { get; set; }

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

    public string? 國曆回報日期_展示 { get; set; }

    public string? 國曆通報日期_展示 { get; set; }

    public string? 國曆回報日期_索引 { get; set; }

    public string? 國曆通報日期_索引 { get; set; }

    public string? 連絡人 { get; set; }
}
