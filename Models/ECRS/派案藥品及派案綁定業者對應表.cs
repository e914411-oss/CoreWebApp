using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 派案藥品及派案綁定業者對應表
{
    public int 派案藥品及派案綁定業者對應表主鍵 { get; set; }

    public bool? 對應案件類別 { get; set; }

    public int? 對應案件類別識別碼 { get; set; }

    public int? 綁定業者主鍵 { get; set; }

    public string? 指定稽查人員主鍵 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
