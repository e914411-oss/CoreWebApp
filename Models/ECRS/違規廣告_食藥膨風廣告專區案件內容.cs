using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_食藥膨風廣告專區案件內容
{
    public string 違規案件編號 { get; set; } = null!;

    public string? 網站名稱 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 涉嫌違規宣稱詞句 { get; set; }

    public int? 涉嫌違規態樣 { get; set; }

    public string? IP位置 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }
}
