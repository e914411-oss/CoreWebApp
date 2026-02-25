using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP現場稽查描述表紀錄
{
    public int 完成HACCP稽查主表主鍵 { get; set; }

    public DateTime 記錄日期 { get; set; }

    public int 完成主鍵 { get; set; }

    public int 主鍵 { get; set; }

    public int? HACCP稽查主表主鍵 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 照片檔案名稱 { get; set; }

    public byte[]? 照片檔案 { get; set; }
}
