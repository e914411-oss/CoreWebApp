using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_新聞通報
{
    public int 新聞通報主鍵 { get; set; }

    public string 標題 { get; set; } = null!;

    public string? 內容 { get; set; }

    public string? 上架時間_Idx { get; set; }

    public string? 下架時間_Idx { get; set; }

    public string? 上架時間_Show { get; set; }

    public string? 下架時間_Show { get; set; }

    public DateTime? 上架時間 { get; set; }

    public DateTime? 下架時間 { get; set; }

    public string? 發布_目標 { get; set; }

    public string? 建立人員 { get; set; }

    public string? Country { get; set; }

    public string? City_Name { get; set; }

    public string? Targets { get; set; }

    public string? TargetIds { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }

    public string? 檔名路徑 { get; set; }
}
