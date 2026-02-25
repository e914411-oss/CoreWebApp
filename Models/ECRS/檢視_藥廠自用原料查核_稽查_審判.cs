using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_藥廠自用原料查核_稽查_審判
{
    public int 主鍵 { get; set; }

    public string? 發文字號_號 { get; set; }

    public string? 衛生局 { get; set; }

    public string? 主旨 { get; set; }

    public string? 受處分人 { get; set; }

    public string? 負責人 { get; set; }

    public string? 受處分人營業地址 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 身分證字號 { get; set; }

    public DateOnly? 出生日期 { get; set; }

    public string? 性別 { get; set; }

    public string 戶籍地址 { get; set; } = null!;

    public string? 處分書送達地址 { get; set; }

    public string 聯絡電話 { get; set; } = null!;

    public string 違反法規_舊 { get; set; } = null!;

    public int? 罰緩 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 裁處理由 { get; set; }
}
