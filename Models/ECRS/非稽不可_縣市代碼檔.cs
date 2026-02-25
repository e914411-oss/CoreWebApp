using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_縣市代碼檔
{
    public string 縣市代碼編號 { get; set; } = null!;

    public string? 縣市名稱 { get; set; }

    public string? 刪除註記 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
