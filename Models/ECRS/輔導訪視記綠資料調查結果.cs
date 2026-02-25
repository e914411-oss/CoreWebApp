using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視記綠資料調查結果
{
    public int 資料調查結果編號 { get; set; }

    public int 輔導記錄主檔編號 { get; set; }

    public int 資料調查題目檔編號 { get; set; }

    public string? 調查結果 { get; set; }
}
