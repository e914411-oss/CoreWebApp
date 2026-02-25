using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視記錄資料驗證結果
{
    public int 資料驗證結果編號 { get; set; }

    public int 輔導記錄主檔編號 { get; set; }

    public int 資料驗證題目檔編號 { get; set; }

    public string 驗證結果 { get; set; } = null!;

    public string? 驗證結果說明 { get; set; }
}
