using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填報範例檔案
{
    public int 特殊事件填報範例檔案編號 { get; set; }

    public int? 特殊事件通報主檔編號 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 填報頻率 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }

    public byte[]? 資料儲存實體 { get; set; }

    public string? 衛生局編號 { get; set; }
}
