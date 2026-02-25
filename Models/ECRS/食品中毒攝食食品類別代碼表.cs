using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒攝食食品類別代碼表
{
    public int 主鍵 { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    public string? 類別代碼 { get; set; }

    /// <summary>
    /// 中文
    /// </summary>
    public string? 類別名稱 { get; set; }

    /// <summary>
    /// 類別中文名
    /// </summary>
    public string? 類別代碼第1碼 { get; set; }

    /// <summary>
    /// 食品檢體大類別(病因類別)
    /// </summary>
    public string? 食品檢體大類別_病因類別 { get; set; }

    /// <summary>
    /// 食品檢體註記 食品:Y 非食品:N
    /// </summary>
    public string? 食品檢體註記 { get; set; }

    /// <summary>
    /// 刪除註記
    /// </summary>
    public string? 刪除註記 { get; set; }

    /// <summary>
    /// 建立之日期時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立之使用者代碼
    /// </summary>
    public string? 建立人員ID { get; set; }

    /// <summary>
    /// 建立之日期時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 修改之使用者代碼
    /// </summary>
    public string? 異動人員ID { get; set; }

    /// <summary>
    /// 刪除之日期時間
    /// </summary>
    public DateTime? 刪除時間 { get; set; }

    /// <summary>
    /// 刪除之使用者姓名
    /// </summary>
    public string? 刪除人員ID { get; set; }

    /// <summary>
    /// 是否啟用
    /// </summary>
    public string 是否啟用 { get; set; } = null!;

    /// <summary>
    /// 顯示順序
    /// </summary>
    public int 排序索引 { get; set; }
}
