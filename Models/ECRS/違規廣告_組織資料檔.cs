using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_組織資料檔
{
    public string 組織流水號 { get; set; } = null!;

    public string 組織名稱 { get; set; } = null!;

    public string 組織描述 { get; set; } = null!;

    public string? 上層組織流水號 { get; set; }

    public bool 是否為處分機關 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public int? 辦公所屬區域 { get; set; }
}
