using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_違規案件檔案
{
    public int 檔案流水號 { get; set; }

    public string? 案件編號 { get; set; }

    public string? 案件媒體類型 { get; set; }

    public string? 檔案類型 { get; set; }

    public string? 檔案名稱 { get; set; }

    public byte[]? 檔案內容 { get; set; }

    public DateTime 上傳日期 { get; set; }
}
