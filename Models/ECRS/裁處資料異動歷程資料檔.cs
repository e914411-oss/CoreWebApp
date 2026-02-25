using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料異動歷程資料檔
{
    public int 異動歷程編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public DateTime 異動時間 { get; set; }

    public string 異動人員 { get; set; } = null!;
}
