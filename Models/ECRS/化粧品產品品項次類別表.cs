using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品產品品項次類別表
{
    public int 品項次類別編號 { get; set; }

    public int? 品項主類別編號 { get; set; }

    public string? 化粧品產品登錄平台_品項次類別代碼 { get; set; }

    public string? 化粧品產品登錄平台_品項次類別名稱 { get; set; }

    public int? 品項次類排序 { get; set; }

    public string? 是否啟用 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }
}
