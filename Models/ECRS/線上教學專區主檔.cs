using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 線上教學專區主檔
{
    public int 課程編號 { get; set; }

    public string 課程名稱 { get; set; } = null!;

    public string 課程連結 { get; set; } = null!;

    public bool 是否上架 { get; set; }

    public string? 更新人員 { get; set; }

    public DateTime? 更新日期 { get; set; }
}
