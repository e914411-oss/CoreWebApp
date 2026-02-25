using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 測試速率_測試結果記錄檔
{
    public int 系統編號 { get; set; }

    public int? 測試案件編號 { get; set; }

    public string? 系統名稱 { get; set; }

    public string? 測試項目 { get; set; }

    public string? 使用者IP位址 { get; set; }

    public string? 使用者TCP連接埠 { get; set; }

    public string? 呼叫時間 { get; set; }

    public string? 回應時間 { get; set; }

    public int? 處理時間 { get; set; }

    public string? 系統主機名稱 { get; set; }

    public string? 伺服器TCP連接埠 { get; set; }

    public string? 回傳狀態 { get; set; }

    public string? 失敗訊息 { get; set; }

    public string? SessionID { get; set; }

    public string? Session有效時間 { get; set; }
}
