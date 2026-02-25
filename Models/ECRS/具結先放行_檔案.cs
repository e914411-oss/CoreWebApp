using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 具結先放行_檔案
{
    public int 主鍵 { get; set; }

    public string? 全域唯一識別碼 { get; set; }

    public string? 檔案名稱 { get; set; }

    public byte[]? 檔案內容 { get; set; }
}
