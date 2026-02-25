using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件登錄廠商資料檔
{
    public string 違規案件編號 { get; set; } = null!;

    public string 廠商名稱 { get; set; } = null!;

    public string 廠商地址 { get; set; } = null!;

    public string 廠商電話 { get; set; } = null!;

    public string 負責人 { get; set; } = null!;

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 廠商統一標號 { get; set; }

    public string? 廠商類型 { get; set; }

    public string? 個人_姓名 { get; set; }

    public string? 個人_聯絡電話 { get; set; }

    public string? 個人_地址 { get; set; }

    public string? 個人_身分證字號 { get; set; }

    public string? 個人_帳號 { get; set; }
}
