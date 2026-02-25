using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP追蹤追溯稽查紀錄
{
    public int GHP追蹤追溯編號 { get; set; }

    public int GHP稽查編號 { get; set; }

    public string? 產品作業型態 { get; set; }

    public string? 是否為應電子申報之產品類別 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 是否為_應標示基因改造食品_ { get; set; }

    public string? 是否為_宣稱非基因改造食品_ { get; set; }

    public string? 稽查結果 { get; set; }

    public DateOnly? 限期改善日期 { get; set; }

    public string? 現場稽查工作記錄 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
