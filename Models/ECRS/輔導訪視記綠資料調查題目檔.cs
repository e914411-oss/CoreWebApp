using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視記綠資料調查題目檔
{
    public int 資料調查題目檔編號 { get; set; }

    public string 題號代碼 { get; set; } = null!;

    public string 題目 { get; set; } = null!;

    public string 題目類別 { get; set; } = null!;

    public int 題目年度 { get; set; }

    public string 題目種類 { get; set; } = null!;
}
