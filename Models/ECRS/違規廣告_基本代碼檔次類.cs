using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_基本代碼檔次類
{
    public int 代碼流水號 { get; set; }

    public int 代碼群組流水號 { get; set; }

    public string 代碼內容 { get; set; } = null!;

    public int 代碼排序 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 產品類別 { get; set; }
}
