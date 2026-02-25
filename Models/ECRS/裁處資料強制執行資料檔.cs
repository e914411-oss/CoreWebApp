using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料強制執行資料檔
{
    public int 強制執行系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號_字 { get; set; }

    public string? 發文字號_號 { get; set; }

    public string? 函送法務部行政執行 { get; set; }
}
