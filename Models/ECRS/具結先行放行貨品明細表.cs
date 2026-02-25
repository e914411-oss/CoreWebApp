using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先行放行貨品明細表
{
    public decimal 主鍵 { get; set; }

    /// <summary>
    /// 資料日期
    /// </summary>
    public DateTime? 資料寫入日期 { get; set; }

    /// <summary>
    /// 報驗案號
    /// </summary>
    public string? 報驗案號 { get; set; }

    /// <summary>
    /// 貨品分類號列
    /// </summary>
    public string? 貨品分類號列 { get; set; }

    /// <summary>
    /// 中文品名
    /// </summary>
    public string? 產品中文名稱 { get; set; }

    /// <summary>
    /// 英文品名
    /// </summary>
    public string? 產品英文名稱 { get; set; }

    /// <summary>
    /// 產品規格
    /// </summary>
    public string? 規格 { get; set; }

    /// <summary>
    /// 生產國別(代碼)
    /// </summary>
    public string? 產地代碼 { get; set; }

    /// <summary>
    /// 生產國別(名稱)
    /// </summary>
    public string? 產地名稱 { get; set; }

    /// <summary>
    /// 內裝數量
    /// </summary>
    public double? 內裝數量 { get; set; }

    /// <summary>
    /// 內裝數量(單位)
    /// </summary>
    public string? 內裝數量單位 { get; set; }

    /// <summary>
    /// 報單數量
    /// </summary>
    public decimal? 報單數量 { get; set; }

    /// <summary>
    /// 報單數量(單位)
    /// </summary>
    public string? 報單數量單位 { get; set; }

    public string? IFI系統PK { get; set; }
}
