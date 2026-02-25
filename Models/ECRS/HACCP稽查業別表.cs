using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class HACCP稽查業別表
{
    public int 主鍵 { get; set; }

    public int? HACCP稽查主表主鍵 { get; set; }

    public string? 稽查業別主類編號 { get; set; }

    public string? 稽查業別次類編號 { get; set; }

    public DateTime? 修改時間 { get; set; }
}
