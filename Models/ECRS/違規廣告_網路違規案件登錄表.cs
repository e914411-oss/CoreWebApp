using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_網路違規案件登錄表
{
    public string 違規案件編號 { get; set; } = null!;

    public int 案件進度 { get; set; }

    public string? 併案主案件編號 { get; set; }

    public string? 併罰主案件編號 { get; set; }

    public string 案件來源機關 { get; set; } = null!;

    public string? 機關收文號 { get; set; }

    public DateTime 監控日期 { get; set; }

    public string 網站名稱 { get; set; } = null!;

    public string 所屬入口網站 { get; set; } = null!;

    public string? 網址 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string 產品類別 { get; set; } = null!;

    public string 違規類型 { get; set; } = null!;

    public string 訂購方式 { get; set; } = null!;

    public DateTime? 交查日期 { get; set; }

    public string? 交查單位 { get; set; }

    public string? 附註 { get; set; }

    public string 廣告內容 { get; set; } = null!;

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }
}
