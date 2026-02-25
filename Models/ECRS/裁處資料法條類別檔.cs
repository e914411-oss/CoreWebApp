using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料法條類別檔
{
    public int 裁處法條編號 { get; set; }

    public string 法條名稱 { get; set; } = null!;

    public bool 是否啟用 { get; set; }

    public bool 是否為文字輸入 { get; set; }

    public DateOnly 建立日期 { get; set; }
}
