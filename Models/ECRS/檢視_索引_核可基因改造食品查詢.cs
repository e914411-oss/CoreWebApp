using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_核可基因改造食品查詢
{
    public int 流水編號 { get; set; }

    public string 統一編號 { get; set; } = null!;

    public string? 類別 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string breed說明 { get; set; } = null!;

    public string? 申請者名稱 { get; set; }

    public DateTime 到達時間 { get; set; }

    public DateTime 核定時間 { get; set; }

    public string? 到達時間_索引 { get; set; }

    public string? 核定時間_索引 { get; set; }

    public string? 到達時間_國曆 { get; set; }

    public string? 核定時間_國曆 { get; set; }

    public short 產品類型 { get; set; }

    public string 產品類型SHOW { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public short? 語系 { get; set; }

    public int 索引主鍵 { get; set; }

    public string? 索引名稱 { get; set; }
}
