using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_食品工廠逾兩年未稽查
{
    public int? 業者編號 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string? 縣市 { get; set; }

    public string? 鄉鎮區 { get; set; }

    public string? 街道 { get; set; }

    public string? 次業別 { get; set; }

    public string? 最近稽查日期 { get; set; }

    public string? 縣市代號 { get; set; }

    public string? 推播 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
