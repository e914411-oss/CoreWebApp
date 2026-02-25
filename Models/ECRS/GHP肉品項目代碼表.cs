using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP肉品項目代碼表
{
    public int 主鍵 { get; set; }

    public string 肉品來源查核項目名稱 { get; set; } = null!;

    public string? 是否啟用 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 排序 { get; set; }
}
