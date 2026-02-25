using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案浮動欄位資料表
{
    public int 專案浮動欄位資料表主鍵 { get; set; }

    public int? 專案浮動欄位設定表主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 稽查項目類型 { get; set; }

    public string? 稽查項目類型代碼 { get; set; }

    public string? 浮動欄位資料 { get; set; }
}
