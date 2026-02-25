using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP追溯追蹤查核表
{
    public int 主鍵 { get; set; }

    public int GHP稽查主表主鍵 { get; set; }

    public string? 產品作業型態 { get; set; }

    public string? 為應電子申報之產品類別 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 為應標示基因改造食品 { get; set; }

    public string? 為宣稱非基因改造食品 { get; set; }

    public string? 稽查結果 { get; set; }

    public DateOnly? 限期改善日期 { get; set; }

    public string? 現場稽查工作記錄 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
