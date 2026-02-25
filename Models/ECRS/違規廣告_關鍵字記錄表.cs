using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_關鍵字記錄表
{
    public int 編號 { get; set; }

    public string 關鍵字 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }
}
