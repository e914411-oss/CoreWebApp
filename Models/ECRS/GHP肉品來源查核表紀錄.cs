using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP肉品來源查核表紀錄
{
    public int GHP肉品來源查核表完成主鍵 { get; set; }

    public int? 完成主鍵 { get; set; }

    public int? 主鍵 { get; set; }

    public int? GHP稽查主表主鍵 { get; set; }

    public int? GHP肉品項目主鍵 { get; set; }

    public string? 肉品來源查核結果代碼 { get; set; }

    public string? 肉品來源查核結果名稱 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
