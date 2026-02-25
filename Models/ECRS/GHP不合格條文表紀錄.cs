using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP不合格條文表紀錄
{
    public int 紀錄主鍵 { get; set; }

    public int? 完成主鍵 { get; set; }

    /// <summary>
    /// ID (GHP稽查項目紀錄及不合格備註)
    /// </summary>
    public int? 主鍵 { get; set; }

    /// <summary>
    /// GHP ID
    /// </summary>
    public int? GHP稽查主表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 稽查項目編號
    /// </summary>
    public int? GHP條文主鍵 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? 條文內容 { get; set; }

    /// <summary>
    /// 是否合格 Y/N
    /// </summary>
    public string? 是否合格 { get; set; }

    /// <summary>
    /// 不合格項目備註欄
    /// </summary>
    public string? 不合格備註 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
