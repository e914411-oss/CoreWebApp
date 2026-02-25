using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_考評分數管理表_104年
{
    public int 系統流水號 { get; set; }

    public string? 違規案件編號 { get; set; }

    public string? 處分機關 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 狀態 { get; set; }

    public string? 媒體類別 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public int? 分數紀錄 { get; set; }

    public int? 扣除紀錄 { get; set; }

    public bool 處分天數是否小於50天 { get; set; }

    public bool 移查天數是否小於15天 { get; set; }
}
