using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 追溯追蹤工作紀錄照片檔
{
    public int 工作紀錄照片明細ID { get; set; }

    public int? 追溯追蹤稽查ID { get; set; }

    public byte[]? 現場稽查照片 { get; set; }

    public string? 檔案名稱 { get; set; }
}
