using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 焦點快訊_發布對象表
{
    public int 焦點快訊主鍵 { get; set; }

    public string 發布對象 { get; set; } = null!;

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime 建立時間 { get; set; }
}
