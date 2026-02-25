using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記產品查核主表
{
    public int 主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 稽查日期_國曆 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public virtual ICollection<查驗登記產品查核明細表> 查驗登記產品查核明細表s { get; set; } = new List<查驗登記產品查核明細表>();
}
