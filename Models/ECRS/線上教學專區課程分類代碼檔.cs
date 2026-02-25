using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 線上教學專區課程分類代碼檔
{
    public int 課程分類編號 { get; set; }

    public string 分類名稱 { get; set; } = null!;

    public bool 是否啟用 { get; set; }

    public int? 父課程分類編號 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
