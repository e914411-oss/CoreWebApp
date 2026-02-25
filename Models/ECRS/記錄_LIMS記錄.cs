using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_LIMS記錄
{
    public int? 案件編號 { get; set; }

    public string? 檢驗主類別 { get; set; }

    public string? 檢驗次類別 { get; set; }

    public string? 檢驗細類別 { get; set; }

    public string? 檢體名稱 { get; set; }

    public string? 檢驗結果值 { get; set; }

    public string? 判定結果 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 訊息內容 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 批號 { get; set; }

    public string? APP標記 { get; set; }

    public string? 類型 { get; set; }

    public int 稽查項目 { get; set; }
}
