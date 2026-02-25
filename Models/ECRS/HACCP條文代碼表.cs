using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP條文代碼表
{
    public string 主鍵 { get; set; } = null!;

    public bool? 是否為標題 { get; set; }

    public int? 編號1 { get; set; }

    public int? 編號2 { get; set; }

    public int? 編號3 { get; set; }

    public string? 查檢條文 { get; set; }

    public string? 查核重點 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public int? 未使用1 { get; set; }

    public decimal? 未使用2 { get; set; }

    public decimal? 未使用3 { get; set; }

    public string? 是否啟用 { get; set; }
}
