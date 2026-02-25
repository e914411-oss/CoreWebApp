using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 用藥安全新聞通報主表
{
    /// <summary>
    /// 用藥安全新聞通報ID
    /// </summary>
    public int 用藥安全新聞通報主表_主鍵 { get; set; }

    /// <summary>
    /// 活動名稱
    /// </summary>
    public string? 活動名稱 { get; set; }

    /// <summary>
    /// 活動日期
    /// </summary>
    public DateTime? 活動日期 { get; set; }

    /// <summary>
    /// 舉辦地點
    /// </summary>
    public string? 舉辦地點 { get; set; }

    public string? 活動主題 { get; set; }

    /// <summary>
    /// 宣傳主軸
    /// </summary>
    public string? 宣傳主軸 { get; set; }

    /// <summary>
    /// 主辦單位
    /// </summary>
    public string? 主辦單位 { get; set; }

    /// <summary>
    /// 協辦單位
    /// </summary>
    public string? 協辦單位 { get; set; }

    /// <summary>
    /// 參加人數
    /// </summary>
    public string? 參加人數 { get; set; }

    /// <summary>
    /// 宣傳管道
    /// </summary>
    public string? 宣傳管道 { get; set; }

    /// <summary>
    /// 宣傳類別
    /// </summary>
    public string? 宣傳類別 { get; set; }

    public string? 醫療器材相關通報 { get; set; }

    public string? 化粧品相關通報 { get; set; }

    public string? 藥品相關通報 { get; set; }

    public string? 食品相關通報 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }
}
