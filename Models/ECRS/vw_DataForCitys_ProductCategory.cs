using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_DataForCitys_ProductCategory
{
    public string 產品別主分類編號 { get; set; } = null!;

    public string? 產品別主分類名稱 { get; set; }

    public string 產品別次分類編號 { get; set; } = null!;

    public string? 產品別次分類名稱 { get; set; }

    public string 產品別細分類編號 { get; set; } = null!;

    public string? 產品別細分類名稱 { get; set; }

    public DateTime? 主異動日期 { get; set; }

    public DateTime? 次異動日期 { get; set; }

    public DateTime? 細異動日期 { get; set; }
}
