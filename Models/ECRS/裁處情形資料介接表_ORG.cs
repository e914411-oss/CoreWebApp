using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處情形資料介接表_ORG
{
    public int PK { get; set; }

    public string? 衛生局 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 主旨 { get; set; }

    public int? 處分類別 { get; set; }

    public string? 處分對象 { get; set; }

    public string? 受處分人 { get; set; }

    public string? 負責人 { get; set; }

    public string? 受處分人營業地址 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 身分證字號 { get; set; }

    public DateOnly? 出生日期 { get; set; }

    public int? 性別 { get; set; }

    public string? 戶籍地址 { get; set; }

    public string? 處分書送達地址 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 違反法規 { get; set; }

    public int? 罰緩 { get; set; }

    public DateOnly? 回收期限 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 裁處理由 { get; set; }

    public string? 狀態 { get; set; }

    public string? 資料來源 { get; set; }

    public string? 衛生局編號 { get; set; }
}
