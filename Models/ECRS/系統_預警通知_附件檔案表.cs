using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_附件檔案表
{
    public int 主鍵 { get; set; }

    public DateOnly? 日期 { get; set; }

    public string? 縣市 { get; set; }

    public string? 權限 { get; set; }

    public string? 人員帳號 { get; set; }

    public string? 檔案名稱 { get; set; }

    public byte[]? 檔案 { get; set; }

    public string? 類型 { get; set; }
}
