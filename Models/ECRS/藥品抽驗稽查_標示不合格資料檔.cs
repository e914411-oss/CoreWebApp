using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品抽驗稽查_標示不合格資料檔
{
    public int 抽驗_標示不合格系統編號 { get; set; }

    public int? 稽查明細表編號 { get; set; }

    public int? 標示不合格項目主類別編號 { get; set; }

    public int? 標示不合格項目次類別編號 { get; set; }

    public string? 稽查結果 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員編號 { get; set; }

    public string? 稽查結果其他說明 { get; set; }
}
