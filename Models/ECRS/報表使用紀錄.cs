using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 報表使用紀錄
{
    public int 編號 { get; set; }

    public string 報表編號 { get; set; } = null!;

    public string 使用者編號 { get; set; } = null!;

    public string 部門代碼 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }
}
