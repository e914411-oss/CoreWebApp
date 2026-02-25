using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_教育部介接_抽驗不合格記錄
{
    public int 主鍵 { get; set; }

    public DateTime 記錄時間 { get; set; }

    public string? IP地址 { get; set; }

    public string? 查詢資料起始日期 { get; set; }

    public string? 查詢資料結束日期 { get; set; }

    public int? 執行時間 { get; set; }

    public int? 資料筆數 { get; set; }

    public string? 是否錯誤 { get; set; }
}
