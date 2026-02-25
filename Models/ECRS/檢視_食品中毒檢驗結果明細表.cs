using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒檢驗結果明細表
{
    public int 食品中毒檢驗結果明細表_主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 檢驗項目類別 { get; set; }

    public string? 檢驗項目 { get; set; }

    public string? 檢體類別 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string 檢驗結果 { get; set; } = null!;

    public string? 病因物質 { get; set; }

    public string? 菌數毒素含量範圍 { get; set; }

    public string? 菌數毒素含量 { get; set; }

    public string? 血清型毒素名稱 { get; set; }

    public int? 檢體抽驗編號 { get; set; }

    public string? 陽性數量 { get; set; }
}
