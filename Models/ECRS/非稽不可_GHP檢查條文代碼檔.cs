using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP檢查條文代碼檔
{
    public int GHP檢查條文編號 { get; set; }

    public string? 業別主分類代碼 { get; set; }

    public string? 條款內容 { get; set; }

    public string? 啟用註記 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
