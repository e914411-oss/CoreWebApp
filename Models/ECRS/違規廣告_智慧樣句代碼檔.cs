using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_智慧樣句代碼檔
{
    public int 樣句流水號 { get; set; }

    public string 樣句片語 { get; set; } = null!;

    public string 使用者帳號 { get; set; } = null!;
}
