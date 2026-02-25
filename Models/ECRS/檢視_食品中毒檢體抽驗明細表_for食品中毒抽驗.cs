using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒檢體抽驗明細表_for食品中毒抽驗
{
    public int 食品中毒檢體抽驗明細表_主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 案件編號 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public string? 檢體類別 { get; set; }

    public string? 件數 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 檢體名稱_中文 { get; set; }

    public string? 採樣日期 { get; set; }

    public string? 採樣時間 { get; set; }

    public string? 連絡電話 { get; set; }

    public string? 填報人員 { get; set; }

    public string? 運送保存方式 { get; set; }

    public string? 前調理方式 { get; set; }

    public string? 備註 { get; set; }

    public string? 檢驗單位 { get; set; }

    public string? 分機 { get; set; }
}
