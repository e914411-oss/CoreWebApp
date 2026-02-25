using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非登不可_食品業者主動通報稽查情形
{
    public int 系統編號 { get; set; }

    public int? 通報案件編號 { get; set; }

    public string? 稽查縣市 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 稽查時間_時 { get; set; }

    public string? 稽查時間_分 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 違規事實_販賣 { get; set; }

    public string? 違規事實_辦理回收 { get; set; }

    public string? 稽查備註 { get; set; }

    public double? 處辦情形_下架公斤 { get; set; }

    public double? 處辦情形_回收公斤 { get; set; }

    public double? 處辦情形_封存公斤 { get; set; }

    public string? 處辦情形_行政處分 { get; set; }

    public string? 處辦情形_命業者停業 { get; set; }

    public string? 處辦情形_命業者歇業 { get; set; }

    public string? 處辦情形_其他 { get; set; }

    public string? 處辦情形_其他內容 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 違規事實_製造及加工 { get; set; }
}
