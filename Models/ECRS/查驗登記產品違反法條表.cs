using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品違反法條表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// GHP ID
    /// </summary>
    public int? 查驗登記產品查核明細表主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// 稽查項目編號
    /// </summary>
    public int? 查驗登記產品法條主鍵 { get; set; }

    /// <summary>
    /// 條文內容
    /// </summary>
    public string? 法條內容 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public virtual 查驗登記產品查核明細表? 查驗登記產品查核明細表主鍵Navigation { get; set; }
}
