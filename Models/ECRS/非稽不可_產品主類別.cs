using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_產品主類別
{
    public string 產品主分類代碼 { get; set; } = null!;

    public string? 產品主分類名稱 { get; set; }

    public string? 停用註記 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
