using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 業者照片資料檔
{
    public int 檔案流水號 { get; set; }

    public int? 業者編號 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 檔案種類 { get; set; }

    public byte[]? 原始照片 { get; set; }

    public byte[]? 縮圖照片 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 業者照片衛生局主鍵 { get; set; }
}
