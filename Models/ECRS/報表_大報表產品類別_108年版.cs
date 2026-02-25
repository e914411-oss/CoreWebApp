using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 報表_大報表產品類別_108年版
{
    public int 報表產品代碼流水號 { get; set; }

    public string? 報表主類名稱 { get; set; }

    public string? 報表次類名稱 { get; set; }

    public int? 大報表第幾行 { get; set; }

    public int? 大報表第幾列 { get; set; }

    public DateTime? 修改日期 { get; set; }
}
