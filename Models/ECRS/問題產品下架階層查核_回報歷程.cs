using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 問題產品下架階層查核_回報歷程
{
    public int 主鍵 { get; set; }

    public string 案件編號 { get; set; } = null!;

    public int? 上下游商稽查表主鍵 { get; set; }

    public int? 案件階層 { get; set; }

    public int? 上一層主鍵 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 回報產品名稱 { get; set; }

    public decimal? 製造量_進貨量 { get; set; }

    public decimal? 售出量 { get; set; }

    public decimal? 庫存量 { get; set; }

    public decimal? 退回上游量 { get; set; }

    public decimal? 下游退回量 { get; set; }

    public decimal? 封存量 { get; set; }

    public decimal? 其他 { get; set; }

    public string? 備註 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 非登_回收狀態 { get; set; }
}
