using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_非登登錄資料查詢
{
    public DateTime? LastD { get; set; }

    public string? 公司登錄字號 { get; set; }

    public string? 登錄字號 { get; set; }

    public string? 公司商業登記名稱 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 營業地址縣市 { get; set; }

    public string? 營業地址區域 { get; set; }

    public string? 營業地址街道 { get; set; }

    public string? 營業狀態 { get; set; }

    public string 登錄項目 { get; set; } = null!;

    public int 項目編號 { get; set; }

    public string 是否為製造及加工業 { get; set; } = null!;

    public string 是否為餐飲業 { get; set; } = null!;

    public string 是否為輸入業 { get; set; } = null!;

    public string 是否為販售業 { get; set; } = null!;

    public string 是否為物流業 { get; set; } = null!;

    public string? 是否為販售食品添加物業者 { get; set; }

    public string? 是否為製造食品添加物業者 { get; set; }
}
