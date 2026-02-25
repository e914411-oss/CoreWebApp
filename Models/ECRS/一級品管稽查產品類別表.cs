using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 一級品管稽查產品類別表
{
    public int 產品類別ID { get; set; }

    public string? 產品類別名稱 { get; set; }

    public int? 排序 { get; set; }

    public string? 主類別編號 { get; set; }
}
