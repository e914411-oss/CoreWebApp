using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 測試速率_測試結果資訊主檔
{
    public int 測試案件編號 { get; set; }

    public string? 姓氏 { get; set; }

    public string? 性別 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? EMail { get; set; }

    public string? 是否已發送郵件 { get; set; }

    public DateTime? 發送郵件時間 { get; set; }

    public DateTime? 建立日期 { get; set; }
}
