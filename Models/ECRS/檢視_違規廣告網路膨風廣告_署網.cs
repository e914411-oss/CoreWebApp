using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告網路膨風廣告_署網
{
    public string 案件編號 { get; set; } = null!;

    public DateTime 上線日期 { get; set; }

    public DateTime? 下線日期 { get; set; }

    public string? 廣告分類 { get; set; }

    public string? 標題 { get; set; }

    public string 刊登單位 { get; set; } = null!;

    public string? 內容 { get; set; }

    public string 圖片說明 { get; set; } = null!;
}
