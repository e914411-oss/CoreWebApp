using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 瘦身美容業現場稽查描述表
{
    public int 瘦身美容業現場稽查描述表主鍵 { get; set; }

    public int? 瘦身美容業稽查主表主鍵 { get; set; }

    public string? 現場稽查紀錄說明 { get; set; }

    public string? 照片檔名 { get; set; }

    public byte[]? 照片 { get; set; }

    public string? 照片檔名2 { get; set; }

    public string? 現場稽查紀錄說明2 { get; set; }
}
