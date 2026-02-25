using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP強制性檢驗查核表
{
    public int 主鍵 { get; set; }

    public int GHP稽查主表主鍵 { get; set; }

    public string? 業別 { get; set; }

    public string? 產品類別 { get; set; }

    public DateOnly? 最近一次強制性檢驗日期 { get; set; }

    public string? 稽查結果 { get; set; }

    public DateOnly? 限期改善日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 檢驗標的 { get; set; }
}
