using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 國際警訊_國際警訊案件稽查情形
{
    public int 系統編號 { get; set; }

    public int? 國際警訊案件主檔編號 { get; set; }

    public string 稽查縣市 { get; set; } = null!;

    public DateOnly 稽查日期 { get; set; }

    public string 稽查時間_時 { get; set; } = null!;

    public string 稽查時間_分 { get; set; } = null!;

    public string? 是否為應回收項目 { get; set; }

    public string? 處辦情形_銷毀 { get; set; }

    public DateOnly? 處辦情形_銷毀日期 { get; set; }

    public double? 處辦情形_銷毀總重 { get; set; }

    public string? 處辦情形_退運 { get; set; }

    public DateOnly? 處辦情形_退運日期 { get; set; }

    public double? 處辦情形_退運總重 { get; set; }

    public string? 處辦情形_行政處分 { get; set; }

    public string? 處辦情形_其它 { get; set; }

    public string? 處辦情形_其它內容 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 稽查人員 { get; set; }
}
