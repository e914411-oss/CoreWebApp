using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class PMDS抽驗不合格OpneData公開給民眾
{
    public int 物品識別碼 { get; set; }

    public string? 產品名稱 { get; set; }

    public string 包裝或散裝 { get; set; } = null!;

    public string 物品重量 { get; set; } = null!;

    public string 物品單位 { get; set; } = null!;

    public string? 製造日期 { get; set; }

    public string? 有效日期 { get; set; }

    public string 批號 { get; set; } = null!;

    public DateOnly? 查獲日期 { get; set; }

    public string? 查獲對象 { get; set; }

    public string 查獲對象統一編號 { get; set; } = null!;

    public string 製造商名稱 { get; set; } = null!;

    public string 製造商地址 { get; set; } = null!;

    public string 來源商名稱 { get; set; } = null!;

    public string 來源商地址 { get; set; } = null!;

    public string 違規情節 { get; set; } = null!;

    public string 違反法條 { get; set; } = null!;

    public string 處理情形 { get; set; } = null!;

    public string? 截止日期 { get; set; }
}
