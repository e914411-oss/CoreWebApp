using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class dw_Product_Category_Main
{
    public string 產品別主分類編號 { get; set; } = null!;

    public string? 產品別主分類名稱 { get; set; }

    public string? 停用註記 { get; set; }

    public int 流水編號 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員編號 { get; set; }
}
