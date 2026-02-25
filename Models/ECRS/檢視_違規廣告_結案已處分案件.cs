using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_結案已處分案件
{
    public string 違規案件編號 { get; set; } = null!;

    public string? 產品類別 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string? 訂購公司或負責人 { get; set; }

    public string? 訂購_公司 { get; set; }

    public string 負責人 { get; set; } = null!;

    public string? 出刊縣市 { get; set; }

    public DateTime? 出刊日期 { get; set; }

    public string? 業者_處分法規 { get; set; }

    public string 違規事實 { get; set; } = null!;

    public DateTime 監控日期 { get; set; }

    public string 媒體類型 { get; set; } = null!;

    public string? 受處罰媒體 { get; set; }

    public string? 查處情形 { get; set; }

    public string? 廠商統一標號 { get; set; }

    public string? 查處情形_輔導文號 { get; set; }

    public string? 查處情形_已處分文號 { get; set; }

    public string? 查處情形_其他備註 { get; set; }

    public DateTime? 查處情形_處分日期 { get; set; }

    public string? 查處情形_媒體提供託播業者資料 { get; set; }
}
