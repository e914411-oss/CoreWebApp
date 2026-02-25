using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_允許上傳格式清單
{
    public int 主鍵 { get; set; }

    public string? 副檔名 { get; set; }

    public string? 新增人員 { get; set; }

    public DateTime? 新增時間 { get; set; }
}
