using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報記錄_豬肉統計寄送名單
{
    public int 主鍵 { get; set; }

    public string? 所屬機關 { get; set; }

    public string? 科室 { get; set; }

    public string? 職位 { get; set; }

    public string? 姓名 { get; set; }

    public string? 電子信箱 { get; set; }

    public string? 寄送啟用 { get; set; }

    public string 備註 { get; set; } = null!;

    public string? 衛生局 { get; set; }

    public string? 跨部會 { get; set; }
}
