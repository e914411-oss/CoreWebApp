using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視業者二級驗證資料檔_107年匯入
{
    public int 系統流水號 { get; set; }

    public int 輔導訪視業者編號 { get; set; }

    public string? FACS驗證序號 { get; set; }

    public DateTime? 驗證日期_起 { get; set; }

    public DateTime? 驗證日期_迄 { get; set; }

    public string? 實際驗證產業 { get; set; }

    public string? 驗證結果 { get; set; }
}
