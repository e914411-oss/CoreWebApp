using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥商_藥局_醫療機構現場稽查照片表
{
    public int 藥商_藥局_醫療機構現場稽查照片表主鍵 { get; set; }

    public int 藥商_藥局_醫療機構現場稽查描述表主鍵 { get; set; }

    public byte[] 照片檔案 { get; set; } = null!;

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 檔案名稱 { get; set; }
}
