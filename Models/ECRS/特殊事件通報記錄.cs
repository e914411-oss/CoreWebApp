using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報記錄
{
    public int 特殊事件通報記錄編號 { get; set; }

    public int 特殊事件通報主檔編號 { get; set; }

    public DateTime 通報時間 { get; set; }

    public string 通報人員 { get; set; } = null!;
}
