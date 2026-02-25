using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS記錄變更資料
{
    public int 主鍵 { get; set; }

    public int? 完成主鍵 { get; set; }

    public string? 稽查項目 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public int? 稽查事件子鍵 { get; set; }

    public string? 變更欄位 { get; set; }

    public string? 變更資料 { get; set; }

    public DateTime? 修改時間 { get; set; }

    public string? 測試值 { get; set; }
}
