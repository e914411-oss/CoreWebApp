using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_未違規結案主案件
{
    public DateTime 年度 { get; set; }

    public string 違規媒體類別 { get; set; } = null!;

    public string? 產品類別 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public int 罰鍰金額 { get; set; }

    public string 案件編號 { get; set; } = null!;

    public string 委刊者 { get; set; } = null!;

    public string? 處分機關 { get; set; }

    public string? 處分法規 { get; set; }

    public string 違規事實 { get; set; } = null!;
}
