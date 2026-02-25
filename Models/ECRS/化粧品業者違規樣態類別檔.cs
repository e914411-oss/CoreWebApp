using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者違規樣態類別檔
{
    public int 樣態編號 { get; set; }

    public string? 違規樣態內容 { get; set; }

    public string? 是否啟用 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 更新日期 { get; set; }
}
