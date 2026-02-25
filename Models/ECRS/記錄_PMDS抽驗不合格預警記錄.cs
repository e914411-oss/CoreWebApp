using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS抽驗不合格預警記錄
{
    public int 主鍵 { get; set; }

    public DateTime 記錄時間 { get; set; }

    public int? 執行時間 { get; set; }

    public int? 結果 { get; set; }

    public string? 訊息內容 { get; set; }

    public int? 資料筆數 { get; set; }

    public string? FSalert識別碼 { get; set; }

    public DateTime 稽查日期 { get; set; }
}
