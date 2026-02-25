using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_食品中毒樣品_結果
{
    public long? No { get; set; }

    public int 食品中毒檢驗結果明細表_主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 檢驗項目類別 { get; set; }

    public string? 檢驗項目 { get; set; }

    public string? 檢體類別 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 有無感染 { get; set; }

    public string? 菌數毒素含量範圍 { get; set; }

    public string? 菌數毒素含量 { get; set; }

    public string? 血清型毒素名稱 { get; set; }

    public int? 檢體抽驗編號 { get; set; }

    public string? 陽性數量 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 件數 { get; set; }

    public string? 採樣日期 { get; set; }

    public string? 採樣時間 { get; set; }

    public string? 前調理方式 { get; set; }

    public string? 運送保存方式 { get; set; }

    public string? 填報人員 { get; set; }

    public string? 連絡電話 { get; set; }

    public string? 檢驗單位 { get; set; }

    public string? 備註 { get; set; }
}
