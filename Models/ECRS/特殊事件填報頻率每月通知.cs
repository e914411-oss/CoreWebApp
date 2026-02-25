using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件填報頻率每月通知
{
    public int 特殊事件填報頻率每月通知編號 { get; set; }

    public int 特殊事件通報主檔編號 { get; set; }

    public string? 日期範圍 { get; set; }

    public DateOnly? 起始時間 { get; set; }

    public DateOnly? 結束時間 { get; set; }

    public string? 檔名 { get; set; }
}
