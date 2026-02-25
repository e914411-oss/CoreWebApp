using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP強制性檢驗查核表_特殊營養食品
{
    public int 主鍵 { get; set; }

    public int GHP稽查表主鍵 { get; set; }

    public string? 產品類別 { get; set; }

    public string? 業別 { get; set; }

    public string? 產名名稱 { get; set; }

    public string? 字號類型 { get; set; }

    public string? 字號內容 { get; set; }

    public DateOnly? 最近一次強制性檢驗日期 { get; set; }

    public string? 稽查結果 { get; set; }

    public DateOnly? 限期改善日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 檢驗標的 { get; set; }

    public string? 產品登錄碼 { get; set; }
}
