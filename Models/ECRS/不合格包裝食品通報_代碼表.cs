using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_代碼表
{
    public int 主鍵 { get; set; }

    public string? 代碼類型 { get; set; }

    public string? 代碼 { get; set; }

    public string? 代碼涵義 { get; set; }

    public string? 停止 { get; set; }

    public string? 縣市 { get; set; }
}
