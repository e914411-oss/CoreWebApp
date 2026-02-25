using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品違反法條表
{
    /// <summary>
    /// 化粧品違反法條編號
    /// </summary>
    public int 主鍵 { get; set; }

    public string? 類別 { get; set; }

    /// <summary>
    /// 法條類別
    /// </summary>
    public string? 法條類別 { get; set; }

    public int? 化粧品稽查明細表主鍵 { get; set; }

    public string? 法條法別代碼 { get; set; }

    /// <summary>
    /// 法條法別
    /// </summary>
    public string? 法條法別 { get; set; }

    /// <summary>
    /// 編號_1 (條)
    /// </summary>
    public string? 編號_1_條 { get; set; }

    /// <summary>
    /// 編號_2 (項)
    /// </summary>
    public string? 編號_2_項 { get; set; }

    /// <summary>
    /// 編號_3 (款)
    /// </summary>
    public string? 編號_3_款 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員主鍵 { get; set; }
}
