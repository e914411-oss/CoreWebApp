using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_食藥膨風廣告專區案件圖片檔
{
    public string 違規案件編號 { get; set; } = null!;

    public string? 檔案名稱 { get; set; }

    public string? 檔案類型 { get; set; }

    public byte[]? 檔案內容 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }
}
