using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒處置結果紀錄表
{
    /// <summary>
    /// 中毒處置結果代碼
    /// </summary>
    public int 食品中毒處置結果紀錄表_主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 中毒速報主檔代碼
    /// </summary>
    public int? 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// id (條款項目及備註)
    /// </summary>
    public int? 條款項目_ID { get; set; }

    /// <summary>
    /// 登錄日期
    /// </summary>
    public string? 登錄日期 { get; set; }

    /// <summary>
    /// 處置結果
    /// </summary>
    public string? 處置結果 { get; set; }

    /// <summary>
    /// 行政處分書-公文日期
    /// </summary>
    public string? 行政處分書_公文日期 { get; set; }

    /// <summary>
    /// 行政處分書-公文字號
    /// </summary>
    public string? 行政處分書_公文字號 { get; set; }

    /// <summary>
    /// 行政處分書-內容摘要
    /// </summary>
    public string? 行政處分書_內容摘要 { get; set; }

    /// <summary>
    /// 移送書-公文日期
    /// </summary>
    public string? 移送書_公文日期 { get; set; }

    /// <summary>
    /// 移送書-公文字號
    /// </summary>
    public string? 移送書_公文字號 { get; set; }

    /// <summary>
    /// 移送書-內容摘要
    /// </summary>
    public string? 移送書_內容摘要 { get; set; }

    /// <summary>
    /// 起訴書-公文日期
    /// </summary>
    public string? 起訴書_公文日期 { get; set; }

    /// <summary>
    /// 起訴書-公文字號
    /// </summary>
    public string? 起訴書_公文字號 { get; set; }

    /// <summary>
    /// 起訴書-內容摘要
    /// </summary>
    public string? 起訴書_內容摘要 { get; set; }

    /// <summary>
    /// 判決書-公文日期
    /// </summary>
    public string? 判決書_公文日期 { get; set; }

    /// <summary>
    /// 判決書-公文字號
    /// </summary>
    public string? 判決書_公文字號 { get; set; }

    /// <summary>
    /// 判決書-內容摘要
    /// </summary>
    public string? 判決書_內容摘要 { get; set; }

    public int? CPR流水號 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 是否為食品中毒案 { get; set; }

    public string? 非食品中毒原因 { get; set; }
}
