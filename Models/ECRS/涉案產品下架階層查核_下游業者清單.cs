using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 涉案產品下架階層查核_下游業者清單
{
    public int 主鍵 { get; set; }

    public int? 上下游商稽查表主鍵 { get; set; }

    public int? 層數 { get; set; }

    public string? 狀態 { get; set; }

    public string? 下游業者名稱 { get; set; }

    public string? 下游業者縣市 { get; set; }

    public string? 下游業者鄉鎮 { get; set; }

    public string? 下游業者街道 { get; set; }

    public string? 下游業者地址 { get; set; }

    public decimal? 售出下游量 { get; set; }

    public decimal? 下架量 { get; set; }

    public decimal? 封存量 { get; set; }

    public decimal? 已退回上游量 { get; set; }

    public bool? 無法釐清 { get; set; }

    public string? 是否註銷 { get; set; }

    public string? 註銷原因 { get; set; }

    public DateTime? 註銷時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 關聯多產品主鍵 { get; set; }

    public string? 衛生局是否已新聞公布名單 { get; set; }

    public string? 產品出貨單據是否已提供 { get; set; }
}
