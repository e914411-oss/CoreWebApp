using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品業者稽查違反法條類別檔
{
    public int 違反法條編號 { get; set; }

    public string? 違反法條名稱 { get; set; }

    public string? 是否啟用 { get; set; }

    public int? 排序 { get; set; }

    public DateTime? 更新日期 { get; set; }
}
