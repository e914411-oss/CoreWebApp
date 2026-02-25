using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP條文代碼表
{
    /// <summary>
    /// 稽查項目編號 (稽查項目單檔 for GHP)
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 業別主分類代碼
    /// </summary>
    public string? 業別主分類主鍵 { get; set; }

    public string? 類別 { get; set; }

    /// <summary>
    /// 條款內容
    /// </summary>
    public string? 條文內容 { get; set; }

    public string? GHP條文版本 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public int? 排序 { get; set; }

    public string? 條文_條 { get; set; }

    public string? 條文_項 { get; set; }

    public string? 條文_款 { get; set; }

    public string? 條文主項說明 { get; set; }

    public string? 條文次項說明 { get; set; }

    public DateTime? 條文上線日期 { get; set; }

    public string? 條文業別 { get; set; }

    public int? 匯出不合格條文統計排序 { get; set; }
}
