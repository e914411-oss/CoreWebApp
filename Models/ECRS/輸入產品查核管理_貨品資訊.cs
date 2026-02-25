using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輸入產品查核管理_貨品資訊
{
    public int 貨品資訊編號 { get; set; }

    public int? 產品查核業者主鍵 { get; set; }

    public int? 上游業者編號 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 數量 { get; set; }

    public string? 批號 { get; set; }

    public string? 國別 { get; set; }

    public int? 來源稽查編號 { get; set; }

    public string? 萊克多巴胺檢出值 { get; set; }

    public string? 出貨日期 { get; set; }

    public DateTime? 放行日期 { get; set; }

    public string? 報驗案號 { get; set; }

    public decimal? 項次 { get; set; }

    public string? 報單號碼 { get; set; }
}
