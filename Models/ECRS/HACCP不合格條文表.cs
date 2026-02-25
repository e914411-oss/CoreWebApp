using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP不合格條文表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// GHP ID
    /// </summary>
    public int? HACCP稽查主表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? HACCP介接主鍵 { get; set; }

    /// <summary>
    /// 稽查項目編號
    /// </summary>
    public string? HACCP條文主鍵 { get; set; }

    /// <summary>
    /// 不合格項目備註欄
    /// </summary>
    public string? 備註 { get; set; }

    public byte[]? 照片檔案 { get; set; }

    public string? 照片檔案名稱 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? HACCP查核重點 { get; set; }

    /// <summary>
    /// 是否合格 Y/N
    /// </summary>
    public string? 查驗結果 { get; set; }

    public string? 未使用 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public virtual HACCP稽查主表? HACCP稽查主表主鍵Navigation { get; set; }
}
