using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫療器材違反法條表
{
    public int 主鍵 { get; set; }

    public string? 類型 { get; set; }

    public string? 法條類別 { get; set; }

    public int? 醫療器材稽查明細表主鍵 { get; set; }

    public string? 法條法別值 { get; set; }

    public string? 法條法別 { get; set; }

    public string? 編號_1_條 { get; set; }

    public string? 編號_2_項 { get; set; }

    public string? 編號_3_款 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
