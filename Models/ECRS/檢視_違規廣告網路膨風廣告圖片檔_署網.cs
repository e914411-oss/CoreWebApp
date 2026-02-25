using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告網路膨風廣告圖片檔_署網
{
    public string 案件編號 { get; set; } = null!;

    public string? 檔案名稱 { get; set; }

    public string? 檔案類型 { get; set; }

    public byte[]? 檔案內容 { get; set; }
}
