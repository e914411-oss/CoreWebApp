using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

/// <summary>
/// 廢棄，改由Trans_Chef_Certificate
/// </summary>
public partial class 廚師證書資料
{
    public string 廚師證號 { get; set; } = null!;

    public string? 姓名 { get; set; }

    public string? 有效日期 { get; set; }

    public string? 任職單位 { get; set; }

    public string? 工作地址 { get; set; }
}
