using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 新聞通報
{
    public int 新聞通報主鍵 { get; set; }

    public string 標題 { get; set; } = null!;

    public string? 內容 { get; set; }

    public DateTime? 上架時間 { get; set; }

    public DateTime? 下架時間 { get; set; }

    public string? 是否發布 { get; set; }

    public string? 發布_目標 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 上次更新時間 { get; set; }

    public string? 上次更新人員 { get; set; }

    public string? 發布單位 { get; set; }
}
