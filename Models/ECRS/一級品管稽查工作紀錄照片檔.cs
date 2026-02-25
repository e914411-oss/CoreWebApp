using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 一級品管稽查工作紀錄照片檔
{
    public int 工作紀錄照片明細ID { get; set; }

    public int? 一級品管ID { get; set; }

    public byte[]? 現場稽查照片 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 執行結果 { get; set; }

    public string? 申請回復 { get; set; }

    public DateTime? 存檔時間 { get; set; }
}
