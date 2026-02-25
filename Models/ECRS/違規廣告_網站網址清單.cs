using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_網站網址清單
{
    public int 網站網址清單編號 { get; set; }

    public string 網站名稱 { get; set; } = null!;

    public string? 網站網址 { get; set; }

    public string? 啟用狀態 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
