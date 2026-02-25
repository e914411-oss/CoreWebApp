using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_Product_Category
{
    public int? Industry_ID { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別主分類名稱 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別次分類名稱 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 產品別細分類名稱 { get; set; }
}
