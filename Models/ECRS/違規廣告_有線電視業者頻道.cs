using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_有線電視業者頻道
{
    public int 頻道流水號 { get; set; }

    public int 業者流水號 { get; set; }

    public string 頻道號碼 { get; set; } = null!;

    public string 頻道名稱 { get; set; } = null!;

    public int 排序 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }
}
