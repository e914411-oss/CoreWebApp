using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_友善連結
{
    public int 友善連結流水號 { get; set; }

    public string 友善連結名稱 { get; set; } = null!;

    public string 友善連結網址 { get; set; } = null!;

    public int 友善連結排序 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }
}
