using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 承諾放行_產品表
{
    public int 主鍵 { get; set; }

    public int 承諾放行_主表_主鍵 { get; set; }

    public string? 產品編號 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 產品英文名稱 { get; set; }

    public string? 產品規格 { get; set; }

    public string? 產品製造國家 { get; set; }

    public string? 內裝數量 { get; set; }

    public string? 申報數量 { get; set; }

    public virtual 承諾放行_主表 承諾放行_主表_主鍵Navigation { get; set; } = null!;
}
