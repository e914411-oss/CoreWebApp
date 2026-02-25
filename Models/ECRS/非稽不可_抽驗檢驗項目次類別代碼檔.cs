using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_抽驗檢驗項目次類別代碼檔
{
    public string 檢驗項目主類別代碼 { get; set; } = null!;

    public string 檢驗項目次類別代碼 { get; set; } = null!;

    public string 檢驗項目次類別名稱 { get; set; } = null!;

    public string? 停用註記 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
