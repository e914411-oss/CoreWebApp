using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_系統_使用者_角色相關
{
    public int 主鍵 { get; set; }

    public string? 使用者ID { get; set; }

    public int 使用者角色 { get; set; }

    public string? 申請來源 { get; set; }

    public string? 是否移除 { get; set; }

    public string? 權限 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立者 { get; set; }

    public DateTime? 更新異動時間 { get; set; }

    public string? 更新者 { get; set; }
}
