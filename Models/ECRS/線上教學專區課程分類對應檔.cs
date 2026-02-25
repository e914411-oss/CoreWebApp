using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 線上教學專區課程分類對應檔
{
    public int 課程分類對應編號 { get; set; }

    public int 課程編號 { get; set; }

    public int 課程分類編號 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
