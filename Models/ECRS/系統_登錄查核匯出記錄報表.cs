using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_登錄查核匯出記錄報表
{
    public int 主鍵 { get; set; }

    public string 登錄字號 { get; set; } = null!;

    public string? 使用者帳號 { get; set; }

    public string? 動作 { get; set; }

    public DateTime 報表日期 { get; set; }

    public string? 市招名稱 { get; set; }
}
