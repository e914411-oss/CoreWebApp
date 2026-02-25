using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_產品名稱主檔
{
    public int 產品編號 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string? 狀態 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }
}
