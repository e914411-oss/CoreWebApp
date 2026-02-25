using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒檢體名稱表
{
    public int 食品中毒檢體名稱表_代碼 { get; set; }

    public int? 食品中毒檢體類別_編號 { get; set; }

    public string? 食品中毒檢體名稱 { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string 是否啟用 { get; set; } = null!;

    /// <summary>
    /// 顯示順序
    /// </summary>
    public int 排序 { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? 創建時間 { get; set; }

    /// <summary>
    /// 建立人員員編
    /// </summary>
    public string? 創建人員 { get; set; }

    /// <summary>
    /// 最後修改員編
    /// </summary>
    public DateTime? 最後異動時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 最後異動人員 { get; set; }
}
