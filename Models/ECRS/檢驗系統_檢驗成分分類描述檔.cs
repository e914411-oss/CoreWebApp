using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統_檢驗成分分類描述檔
{
    public Guid 主鍵 { get; set; }

    public int 排序 { get; set; }

    public int 狀態 { get; set; }

    public string? 備註 { get; set; }

    public string? 介面異動者 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public DateTime? 介接時間 { get; set; }

    public string? 介接系統 { get; set; }

    public DateTime 建檔時間 { get; set; }

    public string? 建檔者 { get; set; }

    public DateTime 修改時間 { get; set; }

    public string? 修改者 { get; set; }

    public string 代碼 { get; set; } = null!;

    public string 名稱 { get; set; } = null!;

    public int 是否停用 { get; set; }

    public string? 類別 { get; set; }

    public DateTime 最近PMDS轉入時間 { get; set; }

    public Guid PMDS系統編號 { get; set; }
}
