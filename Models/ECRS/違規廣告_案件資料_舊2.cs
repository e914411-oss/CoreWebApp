using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件資料_舊2
{
    public int 編號 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public int 案件數 { get; set; }

    public string? 案件來源機關 { get; set; }

    public string? 處分法條 { get; set; }

    public string? 出刊日期 { get; set; }

    public string? 媒體名稱 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 媒體類型 { get; set; }

    public string? 違規廠商 { get; set; }

    public string? 負責人 { get; set; }

    public string? 處分機關 { get; set; }

    public DateTime? 處分日期 { get; set; }

    public string? 處分書字號 { get; set; }

    public int? 總處分金額 { get; set; }

    public string? 違規內容 { get; set; }

    public string? 併案案號 { get; set; }

    public string? 附註 { get; set; }

    public string? 廣告內容 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 更新者帳號 { get; set; } = null!;

    public DateTime 更新時間 { get; set; }
}
