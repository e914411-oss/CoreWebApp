using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 刑責回報專區_檔案附件
{
    public int 主鍵 { get; set; }

    public int? 刑責回報專區_主表主鍵 { get; set; }

    public string? 檔名 { get; set; }

    public string? 上傳人員 { get; set; }

    public DateTime? 上傳時間 { get; set; }

    public byte[]? 檔案實體 { get; set; }
}
