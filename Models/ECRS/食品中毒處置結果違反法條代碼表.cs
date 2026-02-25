using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒處置結果違反法條代碼表
{
    public int 主鍵 { get; set; }

    public int? 重要性 { get; set; }

    public string? 查檢條文 { get; set; }

    public bool? 是否為標題 { get; set; }

    public int? 條 { get; set; }

    public int? 款 { get; set; }

    public int? 項 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public int? 外部鍵 { get; set; }

    public bool? 檢驗文件 { get; set; }

    public bool? 檢驗場景 { get; set; }

    public bool? 主要缺陷 { get; set; }

    public int 排序 { get; set; }
}
