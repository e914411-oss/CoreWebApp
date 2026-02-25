using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_PMDS登入錯誤記錄
{
    public int 主鍵 { get; set; }

    public string? 使用者識別碼 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 登入型態 { get; set; }

    public string? 使用者帳號 { get; set; }
}
