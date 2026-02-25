using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_未結案案件明細
{
    public string 違規案件編號 { get; set; } = null!;

    public string 案件來源機關 { get; set; } = null!;

    public string 產品類別代號 { get; set; } = null!;

    public string 產品類別 { get; set; } = null!;

    public string 媒體類型代號 { get; set; } = null!;

    public string? 媒體類別 { get; set; }

    public string 商品名稱 { get; set; } = null!;

    public string? 廠商_個人名稱 { get; set; }

    public string? 處分_交查機關 { get; set; }

    public DateTime? 交查日期 { get; set; }

    public int? 處辦日數 { get; set; }

    public int? 總辦理日數 { get; set; }
}
