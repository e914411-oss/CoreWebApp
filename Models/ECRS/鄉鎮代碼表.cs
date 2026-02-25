using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 鄉鎮代碼表
{
    public string 鄉鎮編號 { get; set; } = null!;

    public string? 鄉鎮區名稱 { get; set; }

    public string? 刪除註記 { get; set; }

    public string 縣市編號 { get; set; } = null!;

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }

    public int? 排序 { get; set; }
}
