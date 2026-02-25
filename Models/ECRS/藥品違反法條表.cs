using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品違反法條表
{
    public int 主鍵 { get; set; }

    public string? 物品種類 { get; set; }

    public string? 法條類別 { get; set; }

    public int? 藥品稽查明細表主鍵 { get; set; }

    public string? 法條值 { get; set; }

    public string? 法條法別 { get; set; }

    public string? 編號_1_條 { get; set; }

    public string? 編號_2_項 { get; set; }

    public string? 編號_3_款 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
