using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP代碼檔
{
    public int 主鍵 { get; set; }

    public string? 類型 { get; set; }

    public string? 代碼 { get; set; }

    public string? 名稱 { get; set; }

    public string? 是否停用 { get; set; }

    public string? 排序 { get; set; }
}
