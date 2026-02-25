using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_鄉鎮代碼檔
{
    public string 鄉鎮代碼 { get; set; } = null!;

    public string? 鄉鎮名稱 { get; set; }

    public string? 刪除註記 { get; set; }

    public string? 縣市代碼 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
