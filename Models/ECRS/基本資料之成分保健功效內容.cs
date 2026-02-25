using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 基本資料之成分保健功效內容
{
    public string? 文號 { get; set; }

    public string? 保健功效成分含量說明 { get; set; }

    public decimal? 保健功效成分計次 { get; set; }

    public string? 保健功效成分重量單位 { get; set; }

    public string? 保健功效成分代碼 { get; set; }

    public string? 保健功效成分來源 { get; set; }
}
