using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統_檢驗項目代碼檔
{
    public Guid 主鍵 { get; set; }

    public string 代碼 { get; set; } = null!;

    public string 名稱 { get; set; } = null!;

    public int? 預設基數 { get; set; }

    public string? 預設單位 { get; set; }

    public byte 是否停用 { get; set; }

    public DateTime 建立時間 { get; set; }

    public DateTime 修改時間 { get; set; }

    public Guid? 分類描述1 { get; set; }

    public Guid? 分類描述2 { get; set; }

    public DateTime 最近PMDS轉入時間 { get; set; }

    public Guid PMDS系統編號 { get; set; }
}
