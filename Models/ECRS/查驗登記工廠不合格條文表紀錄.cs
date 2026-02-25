using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記工廠不合格條文表紀錄
{
    public int 完成查驗登記工廠不合格條文表主鍵 { get; set; }

    public int? 完成主鍵 { get; set; }

    /// <summary>
    /// ID (IRF稽查項目紀錄及不合格備註)
    /// </summary>
    public int? 主鍵 { get; set; }

    /// <summary>
    /// IRF ID
    /// </summary>
    public int? 查驗登記工廠查核主表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 稽查項目編號
    /// </summary>
    public int? 查驗登記工廠檢查條文主鍵 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? 檢查條文 { get; set; }

    /// <summary>
    /// 是否合格 Y/N
    /// </summary>
    public string? 註記 { get; set; }

    /// <summary>
    /// 不合格項目備註欄
    /// </summary>
    public string? 備註 { get; set; }

    public string? 查驗登記工廠類型代碼 { get; set; }

    public string? 缺失判定 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }
}
