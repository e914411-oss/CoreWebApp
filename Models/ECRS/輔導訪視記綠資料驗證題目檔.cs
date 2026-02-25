using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 輔導訪視記綠資料驗證題目檔
{
    public int 資料驗證題目檔編號 { get; set; }

    public string? 類別代號 { get; set; }

    public string? 類別 { get; set; }

    public string? 題號 { get; set; }

    public string? 權重 { get; set; }

    public string 題目 { get; set; } = null!;

    public string? 法規名稱 { get; set; }

    public string? 法規條款 { get; set; }

    public int 題目年度 { get; set; }

    public string 題目種類 { get; set; } = null!;
}
