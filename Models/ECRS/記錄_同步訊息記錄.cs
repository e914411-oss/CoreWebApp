using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_同步訊息記錄
{
    public int 主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 類型 { get; set; }

    public string? 狀態 { get; set; }

    public DateTime? 時間 { get; set; }

    public int? 總共筆數 { get; set; }

    public int? 成功筆數 { get; set; }

    public int? 失敗筆數 { get; set; }

    public string? 失敗說明 { get; set; }

    public string? IP地址 { get; set; }

    public string? IP同步服務來源 { get; set; }

    public DateTime? 呼叫時間 { get; set; }

    public DateTime? 回應時間 { get; set; }

    public double? 處理時間 { get; set; }

    public string? 呼叫日期參數起 { get; set; }

    public string? 呼叫日期參數迄 { get; set; }

    public string? FLAG類型 { get; set; }

    public string? TPEPK參數 { get; set; }

    public string? 其它呼叫參數 { get; set; }
}
