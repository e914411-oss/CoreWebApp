using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 教育部呼叫權限紀錄表
{
    public int 系統編號 { get; set; }

    public Guid 權限編號 { get; set; }

    public DateTime? 呼叫時間 { get; set; }

    public string? 呼叫IP { get; set; }

    public string? 使用單位 { get; set; }

    public string? 帳號 { get; set; }

    public string? 是否已呼叫 { get; set; }
}
