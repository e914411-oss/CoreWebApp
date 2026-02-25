using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_攝食餐次明細表
{
    /// <summary>
    /// 明細主鍵(Identity)
    /// </summary>
    public int 明細_主鍵 { get; set; }

    /// <summary>
    /// 餐次主表FK
    /// </summary>
    public int 攝食餐次主表_主鍵 { get; set; }

    /// <summary>
    /// 明細序號(1,2,3...)
    /// </summary>
    public int 明細序號 { get; set; }

    /// <summary>
    /// 食品名稱
    /// </summary>
    public string? 食品名稱 { get; set; }

    /// <summary>
    /// 是否食用(True/False)
    /// </summary>
    public string? 是否食用 { get; set; }

    /// <summary>
    /// 是否異味(True/False)
    /// </summary>
    public string? 是否異味 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 備註 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 建立時間(預設UTC時間)
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    public virtual 醫院通報專區_攝食餐次主表 攝食餐次主表_主鍵Navigation { get; set; } = null!;
}
