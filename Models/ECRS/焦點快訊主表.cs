using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 焦點快訊主表
{
    /// <summary>
    /// 識別碼
    /// </summary>
    public int 焦點快訊主鍵 { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    public string 標題 { get; set; } = null!;

    /// <summary>
    /// 內容
    /// </summary>
    public string? 內容 { get; set; }

    /// <summary>
    /// 發佈起日
    /// </summary>
    public DateTime? 上架時間 { get; set; }

    /// <summary>
    /// 發佈迄日
    /// </summary>
    public DateTime? 下架時間 { get; set; }

    /// <summary>
    /// 是否發佈
    /// </summary>
    public string? 是否發布 { get; set; }

    /// <summary>
    /// 發佈對象
    /// </summary>
    public string? 發布_目標 { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 建立人員員編
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 最後修改時間
    /// </summary>
    public DateTime? 上次更新時間 { get; set; }

    /// <summary>
    /// 最後修改人員
    /// </summary>
    public string? 上次更新人員 { get; set; }

    public string? 發布單位 { get; set; }
}
