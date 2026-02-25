using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_系統出錯共通記錄表
{
    public int 主鍵 { get; set; }

    public string? 錯誤功能 { get; set; }

    public DateTime? 記錄時間 { get; set; }

    public string? 功能詳細說明 { get; set; }

    public string? 錯誤訊息 { get; set; }

    public string? 錯誤行數 { get; set; }

    public string? 其他備註 { get; set; }
}
