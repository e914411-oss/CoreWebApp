using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品產品登錄不符合樣態資料檔
{
    public int 系統編號 { get; set; }

    public int? 化粧品稽查明細表編號 { get; set; }

    public int? 不符合樣態編號 { get; set; }

    public DateTime? 建立時間 { get; set; }
}
