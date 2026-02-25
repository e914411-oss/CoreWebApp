using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規藥品廣告資料集
{
    public string 違規案件編號 { get; set; } = null!;

    public string 違規產品名稱 { get; set; } = null!;

    public string? 違規廠商名稱或負責人 { get; set; }

    public string? 處分機關 { get; set; }

    public DateTime? 處分日期 { get; set; }

    public string? 處分法條 { get; set; }

    public string 違規情節 { get; set; } = null!;

    public DateTime 刊播日期 { get; set; }

    public string? 刊播媒體類別 { get; set; }

    public string? 刊播媒體 { get; set; }

    public string? 查處情形 { get; set; }
}
