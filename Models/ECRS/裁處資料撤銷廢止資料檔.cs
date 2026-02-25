using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料撤銷廢止資料檔
{
    public int 撤銷廢止系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public int? 撤銷廢止類別 { get; set; }

    public string? 撤銷廢止其他內容 { get; set; }

    public string? 報驗案號 { get; set; }

    public DateOnly? 撤銷廢止日期 { get; set; }
}
