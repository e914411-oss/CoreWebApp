using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品回收違反法條表
{
    public int 藥品回收違反編號 { get; set; }

    public int? 藥品回收稽查編號 { get; set; }

    public int? 藥品回收法條編號 { get; set; }

    public string? 法條說明 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }
}
