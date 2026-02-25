using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 使用者密碼異動歷程
{
    public int 系統流水號 { get; set; }

    public string 使用者編號 { get; set; } = null!;

    public DateTime 異動日期 { get; set; }

    public string 異動密碼 { get; set; } = null!;
}
