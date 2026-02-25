using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP不合格條文照片表
{
    public int 主鍵 { get; set; }

    public int GHP不合格條文表主鍵 { get; set; }

    public string? 照片名稱 { get; set; }

    public byte[]? 照片檔案 { get; set; }

    public byte[]? 照片縮圖 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員編號 { get; set; }
}
