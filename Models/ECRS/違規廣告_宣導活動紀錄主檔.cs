using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_宣導活動紀錄主檔
{
    public int 活動紀錄系統編號 { get; set; }

    public int 年度 { get; set; }

    public int 類別 { get; set; }

    public int 活動類別 { get; set; }

    public string? 上傳縣市 { get; set; }

    public string? 檔案名稱 { get; set; }

    public string? 檔案類型 { get; set; }

    public byte[]? 檔案內容 { get; set; }

    public string? 刪除註記 { get; set; }

    public DateTime? 上傳日期 { get; set; }

    public string? 上傳人員 { get; set; }
}
