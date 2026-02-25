using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 涉案產品下架階層查核_業者販售產品項目
{
    public int 主鍵 { get; set; }

    public int? 來源主鍵 { get; set; }

    public int? 層數 { get; set; }

    public string? 產品名稱 { get; set; }

    public int? 產品屬性 { get; set; }

    public decimal? 輸入量 { get; set; }

    public decimal? 下游量 { get; set; }

    public decimal? 封存量 { get; set; }

    public decimal? 已退回上游量 { get; set; }

    public DateTime? 效期 { get; set; }

    public string? 規格 { get; set; }

    public string? 批號 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }
}
