using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視表_檢驗系統檢驗成分代碼表
{
    public Guid 檢驗系統_檢驗成分主鍵 { get; set; }

    public string 檢驗系統_檢驗成分代碼 { get; set; } = null!;

    public string 檢驗系統_檢驗成分名稱 { get; set; } = null!;

    public string? 檢驗系統_檢驗成分分類名稱 { get; set; }

    public string? 檢驗系統_檢驗成分分類代碼 { get; set; }

    public byte 是否停用 { get; set; }

    public DateTime 建立時間 { get; set; }
}
