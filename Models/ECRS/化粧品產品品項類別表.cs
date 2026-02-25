using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品產品品項類別表
{
    public int 品項類別主鍵 { get; set; }

    public string? 品項類別名稱 { get; set; }

    public int? 排序 { get; set; }

    public bool? 是否啟用 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }
}
