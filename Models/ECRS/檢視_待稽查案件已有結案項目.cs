using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_待稽查案件已有結案項目
{
    public string? 稽查項目 { get; set; }

    public int? 業者編號 { get; set; }

    public int 非業者手動加入 { get; set; }

    public int 稽查事件序號 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 稽查員編號 { get; set; }

    public string? 是否為承辦退回案件 { get; set; }
}
