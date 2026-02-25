using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒檢驗次類別
{
    public int 食品中毒檢驗次類別_主鍵 { get; set; }

    public int? 食品中毒檢驗主類別_主鍵 { get; set; }

    /// <summary>
    /// 代碼值
    /// </summary>
    public string? 檢驗項目代號 { get; set; }

    public string? 檢驗項目名稱 { get; set; }

    /// <summary>
    /// 代碼描述
    /// </summary>
    public string? 檢驗項目說明 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string? 是否啟用 { get; set; }

    /// <summary>
    /// 顯示順序
    /// </summary>
    public int? 排序 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立人員員編
    /// </summary>
    public string? 建立單位 { get; set; }

    /// <summary>
    /// 最後修改員編
    /// </summary>
    public DateTime? 更新時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 更新單位 { get; set; }
}
