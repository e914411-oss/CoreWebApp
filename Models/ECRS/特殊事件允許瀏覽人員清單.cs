using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件允許瀏覽人員清單
{
    public int 特殊事件允許瀏覽人員清單編號 { get; set; }

    public int? 特殊事件通報主檔編號 { get; set; }

    public string? 瀏覽人員ID { get; set; }

    public string? 類型 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }

    public string? 人員單位 { get; set; }
}
