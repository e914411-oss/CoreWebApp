using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料裁處法條資料檔
{
    public int 裁處法條系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public int? 裁處法條編號 { get; set; }

    public string? 裁處法條_條 { get; set; }

    public string? 裁處法條_項 { get; set; }

    public string? 裁處法條_款 { get; set; }

    public string? 內容 { get; set; }
}
