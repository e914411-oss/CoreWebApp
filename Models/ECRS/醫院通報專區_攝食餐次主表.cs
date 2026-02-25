using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫院通報專區_攝食餐次主表
{
    /// <summary>
    /// 餐次主表主鍵(Identity)
    /// </summary>
    public int 攝食餐次主表_主鍵 { get; set; }

    public int 醫院通報攝食人員明細表_主鍵 { get; set; }

    /// <summary>
    /// 餐次編號(第幾餐0,1,2..)
    /// </summary>
    public int 餐次編號 { get; set; }

    /// <summary>
    /// 攝食日期(只有日期)
    /// </summary>
    public DateOnly? 攝食日期 { get; set; }

    /// <summary>
    /// 攝食時間
    /// </summary>
    public string? 攝食時間 { get; set; }

    /// <summary>
    /// 攝食業者名稱
    /// </summary>
    public string? 業者名稱 { get; set; }

    /// <summary>
    /// 攝食業者地址
    /// </summary>
    public string? 業者地址 { get; set; }

    /// <summary>
    /// 嫌疑餐Y or Nss
    /// </summary>
    public string? 嫌疑餐 { get; set; }

    /// <summary>
    /// 共食前是否已有腸胃道症狀 Y or N
    /// </summary>
    public string? 共食前是否已有腸胃道症狀 { get; set; }

    /// <summary>
    /// 描述/備註
    /// </summary>
    public string? 描述 { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 建立時間(預設UTC時間)
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    public virtual ICollection<醫院通報專區_攝食餐次明細表> 醫院通報專區_攝食餐次明細表s { get; set; } = new List<醫院通報專區_攝食餐次明細表>();
}
