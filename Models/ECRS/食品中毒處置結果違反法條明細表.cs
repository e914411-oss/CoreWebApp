using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒處置結果違反法條明細表
{
    public int 食品中毒處置結果違反法條明細表_主鍵 { get; set; }

    /// <summary>
    /// GHP ID
    /// </summary>
    public int? 食品中毒速報主表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 稽查項目編號
    /// </summary>
    public int? 處置結果違反法條代碼 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? 處置結果違反法條文字 { get; set; }

    /// <summary>
    /// 是否合格 Y/N
    /// </summary>
    public string? 處置結果標記 { get; set; }

    /// <summary>
    /// 不合格項目備註欄
    /// </summary>
    public string? 備註 { get; set; }

    public string? 嚴重程度標記 { get; set; }

    public int? 中毒處置結果ID { get; set; }
}
