using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_新聞通報_C
{
    public int Id { get; set; }

    public string 標題 { get; set; } = null!;

    public string? 內容 { get; set; }

    public DateTime? 開始日期 { get; set; }

    public DateTime? 結束日期 { get; set; }

    public string? 是否推播 { get; set; }

    public string? 推播對象 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 最後編輯時間 { get; set; }

    public int? TifsanId { get; set; }

    public string? 檔案名稱 { get; set; }
}
