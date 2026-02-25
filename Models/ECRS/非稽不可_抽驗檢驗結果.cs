using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_抽驗檢驗結果
{
    public int 抽驗檢驗結果編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public string? 抽驗檢驗_物品名稱 { get; set; }

    public string? 抽驗檢驗_檢查件數 { get; set; }

    public string 抽驗檢驗_檢驗主類別 { get; set; } = null!;

    public string 抽驗檢驗_檢驗次類別 { get; set; } = null!;

    public string 抽驗檢驗_檢驗細類別 { get; set; } = null!;

    public string? 抽驗檢驗_檢驗值 { get; set; }

    public string? 抽驗檢驗_檢驗結果 { get; set; }

    public string? 抽驗檢驗_法規判定說明 { get; set; }

    public string? 判斷LIMS系統是否接入 { get; set; }

    public string? 批號 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
