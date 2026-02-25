using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處系統_裁處法條資料檔
{
    public int 系統編號 { get; set; }

    public int 裁處系統主表編號 { get; set; }

    public int 裁處法條編號 { get; set; }

    public string? 條 { get; set; }

    public string? 項 { get; set; }

    public string? 款 { get; set; }

    public string? 內容 { get; set; }
}
