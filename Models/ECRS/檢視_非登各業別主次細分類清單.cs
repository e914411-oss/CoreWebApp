using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_非登各業別主次細分類清單
{
    public string? 非登業別 { get; set; }

    public string 業別代碼 { get; set; } = null!;

    public string? 業別主類名稱 { get; set; }

    public string? 業別次類名稱 { get; set; }

    public string? 業別細類名稱 { get; set; }

    public string 啟用 { get; set; } = null!;

    public string? 排序 { get; set; }

    public string? 業別內容 { get; set; }
}
