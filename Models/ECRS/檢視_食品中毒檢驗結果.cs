using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒檢驗結果
{
    public int? 中毒速報ID { get; set; }

    public string? 檢體類別 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 檢體件數 { get; set; }

    public string? 檢驗項目 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 菌數_毒素含量 { get; set; }
}
