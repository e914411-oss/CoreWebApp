using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 各稽查結果附件寄信通知排程檔
{
    public long 稽查結果附件排程ID { get; set; }

    public int 稽查結果附件ID { get; set; }

    public string? 申請人 { get; set; }

    public DateTime? 申請日期 { get; set; }

    public DateTime? 寄信日期 { get; set; }

    public int? 保留天數 { get; set; }
}
