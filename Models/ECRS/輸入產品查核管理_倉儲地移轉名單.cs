using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輸入產品查核管理_倉儲地移轉名單
{
    public int 編號 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 非登字號 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 電子信箱 { get; set; }

    public string? 縣市 { get; set; }

    public string? 營登地址街道 { get; set; }

    public string? 是否啟用 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動時間 { get; set; }
}
