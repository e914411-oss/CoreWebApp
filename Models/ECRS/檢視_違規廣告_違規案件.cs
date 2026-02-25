using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_違規案件
{
    public string 違規案件編號 { get; set; } = null!;

    public string 媒體類型 { get; set; } = null!;

    public int 案件進度 { get; set; }

    public string 案件來源機關 { get; set; } = null!;

    public string? 機關收文號 { get; set; }

    public DateTime 監控日期 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string 產品類別 { get; set; } = null!;

    public string 違規類型 { get; set; } = null!;

    public string? 違規類型內容 { get; set; }

    public string? 電台名稱 { get; set; }

    public string? 系統業者 { get; set; }

    public string? 媒體名稱 { get; set; }

    public string? 網站名稱 { get; set; }

    public string? 交查單位 { get; set; }

    public string 處分進度 { get; set; } = null!;

    public string 違規事實 { get; set; } = null!;

    public string 違規廠商 { get; set; } = null!;

    public string 負責人 { get; set; } = null!;

    public DateTime 處分日期 { get; set; }

    public string? 處分法條 { get; set; }

    public string? 處分字號 { get; set; }

    public string 違規內容 { get; set; } = null!;
}
