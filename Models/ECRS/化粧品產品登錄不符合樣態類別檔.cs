using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品產品登錄不符合樣態類別檔
{
    public int 不符合樣態編號 { get; set; }

    public string? 樣態內容 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateTime? 建立時間 { get; set; }
}
