using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_業者產品別對應表
{
    public int 流水編號 { get; set; }

    public int 業者代碼 { get; set; }

    public string? 產品主分類代碼 { get; set; }

    public string? 產品次分類代碼 { get; set; }

    public string? 產品細分類代碼 { get; set; }
}
