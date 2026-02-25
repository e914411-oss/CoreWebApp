using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒_中毒原因
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 中毒原因_細菌性細項 { get; set; }

    public string? 中毒原因_化學性_名稱 { get; set; }

    public string? 中毒原因_化學性_重金屬_名稱 { get; set; }

    public string? 中毒原因_化學性_農藥_名稱 { get; set; }

    public string? 中毒原因_化學性_動物用藥_名稱 { get; set; }

    public string? 中毒原因_化學性_其他_名稱 { get; set; }

    public string? 中毒原因_天然毒_名稱 { get; set; }

    public string 中毒原因_天然毒_動物性_名稱 { get; set; } = null!;

    public string 中毒原因_天然毒_植物性_名稱 { get; set; } = null!;

    public string 中毒原因_天然毒_其他_名稱 { get; set; } = null!;

    public string 中毒原因_特異體質_名稱 { get; set; } = null!;

    public string 中毒原因_其他_名稱 { get; set; } = null!;

    public string 中毒原因_細菌性細項_名稱 { get; set; } = null!;
}
