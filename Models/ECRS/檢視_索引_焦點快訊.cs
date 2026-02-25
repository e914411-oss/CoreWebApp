using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_焦點快訊
{
    public int 焦點快訊主鍵 { get; set; }

    public string 標題 { get; set; } = null!;

    public string? 內容 { get; set; }

    public string? 上架日期_索引 { get; set; }

    public string? 下架日期_索引 { get; set; }

    public string? 上架日期_展示 { get; set; }

    public string? 下架日期_展示 { get; set; }

    public DateTime? 上架時間 { get; set; }

    public DateTime? 下架時間 { get; set; }

    public string? 發布_目標 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 城市 { get; set; }

    public string? 城市名稱 { get; set; }

    public string? 發布對象 { get; set; }

    public string? 發布對象代號 { get; set; }

    public int 索引鍵 { get; set; }

    public string? 索引名稱 { get; set; }
}
