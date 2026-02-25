using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填寫歷程回覆答案
{
    public int 特殊事件填寫歷程回覆答案編號 { get; set; }

    public int 特殊事件填寫歷程問題及說明編號 { get; set; }

    public int 特殊事件通報主檔編號 { get; set; }

    public string? 回覆內容 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
