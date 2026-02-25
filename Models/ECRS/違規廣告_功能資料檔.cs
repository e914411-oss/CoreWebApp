using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_功能資料檔
{
    public int 功能流水號 { get; set; }

    public string 功能名稱 { get; set; } = null!;

    public string 功能描述 { get; set; } = null!;

    public string 功能頁面 { get; set; } = null!;

    public string? 功能頁面控制項 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }
}
