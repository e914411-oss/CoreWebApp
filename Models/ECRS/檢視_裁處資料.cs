using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_裁處資料
{
    public string? 發文日期_民國 { get; set; }

    public string? 識別碼 { get; set; }

    public string? 縣市 { get; set; }

    public string? 主旨 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 受處份人 { get; set; }

    public string? 受處分人營業地址 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 裁處法條 { get; set; }

    public string 行政處份 { get; set; } = null!;

    public string? 罰鍰 { get; set; }

    public string? 違規事實 { get; set; }

    public string? 裁處理由 { get; set; }

    public string? 狀態 { get; set; }

    public string 資料來源 { get; set; } = null!;

    public string? 違反法條 { get; set; }

    public int rid { get; set; }

    public int? 類型 { get; set; }
}
