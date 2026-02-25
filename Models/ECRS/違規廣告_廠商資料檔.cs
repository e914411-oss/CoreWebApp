using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_廠商資料檔
{
    public int 案例流水號 { get; set; }

    public string? 廠商名稱 { get; set; }

    public string? 廠商地址 { get; set; }

    public string? 廠商電話 { get; set; }

    public string? 負責人 { get; set; }

    public string? 註銷註記 { get; set; }

    public string? 建立者帳號 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 更新者帳號 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 廠商Email { get; set; }

    public string? 統一編號 { get; set; }

    public string? 身分證字號 { get; set; }

    public string? 帳號 { get; set; }
}
