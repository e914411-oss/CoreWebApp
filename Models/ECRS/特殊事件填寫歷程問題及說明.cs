using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填寫歷程問題及說明
{
    public int 特殊事件填寫歷程問題及說明編號 { get; set; }

    public int? 特殊事件通報主檔編號 { get; set; }

    public string? 標題 { get; set; }

    public string? 填報說明 { get; set; }

    public string? 填報頻率 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }

    public int? 排序 { get; set; }
}
