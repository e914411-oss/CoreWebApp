using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_廣告規定案例
{
    public int 案例流水號 { get; set; }

    public int 案例類型 { get; set; }

    public string 標題 { get; set; } = null!;

    public string 字號 { get; set; } = null!;

    public string 內文 { get; set; } = null!;

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 附件路徑檔名 { get; set; }

    public string? 網址 { get; set; }
}
