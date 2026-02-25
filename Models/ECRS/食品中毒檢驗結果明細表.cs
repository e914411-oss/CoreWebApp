using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒檢驗結果明細表
{
    /// <summary>
    /// 檢體ID
    /// </summary>
    public int 食品中毒檢驗結果明細表_主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 案件編號
    /// </summary>
    public int? 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 病因物質類別
    /// </summary>
    public string? 檢驗項目類別 { get; set; }

    /// <summary>
    /// 病因物質名稱
    /// </summary>
    public string? 檢驗項目 { get; set; }

    /// <summary>
    /// 檢體分類
    /// </summary>
    public string? 檢體類別 { get; set; }

    /// <summary>
    /// 檢體名稱
    /// </summary>
    public string? 檢體名稱 { get; set; }

    public string 檢驗結果 { get; set; } = null!;

    public string? 病因物質 { get; set; }

    /// <summary>
    /// 含量範圍
    /// </summary>
    public string? 菌數毒素含量範圍 { get; set; }

    /// <summary>
    /// 細菌含量
    /// </summary>
    public string? 菌數毒素含量 { get; set; }

    /// <summary>
    /// 毒素名稱
    /// </summary>
    public string? 血清型毒素名稱 { get; set; }

    public int? 檢體抽驗編號 { get; set; }

    public string? 陽性數量 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 是否為CDC轉入 { get; set; }
}
