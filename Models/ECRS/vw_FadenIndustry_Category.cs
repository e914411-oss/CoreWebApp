using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_FadenIndustry_Category
{
    public int? 業者編號 { get; set; }

    public string? 非登業者業別 { get; set; }

    public string? 非登業者業別代碼 { get; set; }

    public string? 非登業別 { get; set; }

    public string 業別代碼 { get; set; } = null!;

    public string? 業別主類名稱 { get; set; }

    public string? 業別次類名稱 { get; set; }

    public string? 業別細類名稱 { get; set; }

    public string? 業別內容 { get; set; }

    public string? 排序 { get; set; }

    public string 啟用 { get; set; } = null!;

    public string? 業者業別完整內容 { get; set; }
}
