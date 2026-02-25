using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 涉案產品下架階層查核_上下游商稽查表
{
    public int 主鍵 { get; set; }

    public int? 來源主鍵 { get; set; }

    public int? 層數 { get; set; }

    public int? 上一層主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 狀態 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 規格 { get; set; }

    public int? 產品屬性 { get; set; }

    public decimal? 上游業者報廢量 { get; set; }

    public decimal? 上游業者庫存量 { get; set; }

    public string? 下游業者名稱 { get; set; }

    public string? 下游業者縣市 { get; set; }

    public string? 下游業者鄉鎮 { get; set; }

    public string? 下游業者街道 { get; set; }

    public string? 衛生局是否已新聞公布名單 { get; set; }

    public string? 產品出貨單據是否已提供 { get; set; }

    public decimal? 售出下游量 { get; set; }

    public decimal? 下游下架量 { get; set; }

    public decimal? 下游封存量 { get; set; }

    public decimal? 已退回上游量 { get; set; }

    public string? 是否註銷 { get; set; }

    public string? 註銷原因 { get; set; }

    public DateTime? 註銷時間 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public DateTime? 衛生局建立日期 { get; set; }

    public string? 關聯多產品主鍵 { get; set; }

    public string? 產品來源單據是否已提供 { get; set; }
}
