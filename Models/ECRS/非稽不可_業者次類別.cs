using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_業者次類別
{
    public string 業別次類代碼 { get; set; } = null!;

    public string? 業別次類名稱 { get; set; }

    public string? 業別主分類代碼 { get; set; }

    public string? 停用註記 { get; set; }
}
