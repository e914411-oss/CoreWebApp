using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 登錄查核內容次類代碼表
{
    public string 登錄查核內容次類主鍵 { get; set; } = null!;

    public string? 登錄查核內容次類名稱 { get; set; }

    public string? 登錄查核內容主類主鍵 { get; set; }

    public string? 查核對象是否為公司 { get; set; }

    public string? 查核對象是否為工廠製造場所 { get; set; }

    public string? 查核對象是否為餐飲場所 { get; set; }

    public string? 查核對象是否為餐飲場所販售場所 { get; set; }

    public string? 是否啟用 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 查核對象是否為物流場所 { get; set; }
}
