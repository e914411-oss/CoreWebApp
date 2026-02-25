using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_違規傳到PMD
{
    public string 違規案件編號 { get; set; } = null!;

    public string? 衛生局 { get; set; }

    public string 處分對象 { get; set; } = null!;

    public string 受處分人 { get; set; } = null!;

    public string 負責人 { get; set; } = null!;

    public string 受處分人營業地址 { get; set; } = null!;

    public string 統一編號 { get; set; } = null!;

    public string 身分證字號 { get; set; } = null!;

    public string 聯絡電話 { get; set; } = null!;

    public string 違反法規 { get; set; } = null!;

    public int 罰緩 { get; set; }

    public string 違規事實 { get; set; } = null!;

    public string 裁處理由 { get; set; } = null!;

    public string 狀態 { get; set; } = null!;
}
