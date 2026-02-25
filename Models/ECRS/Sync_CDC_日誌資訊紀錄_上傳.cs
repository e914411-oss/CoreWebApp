using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Sync_CDC_日誌資訊紀錄_上傳
{
    public int Sync_CDC_日誌資訊紀錄_上傳_主鍵 { get; set; }

    public string? Sync_狀態 { get; set; }

    public string? Sync_描述 { get; set; }

    public DateTime? 紀錄時間 { get; set; }
}
