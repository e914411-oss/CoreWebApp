using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 代施機構上傳檢驗結果明細表
{
    public int 檢驗結果明細編號 { get; set; }

    public int 檢驗結果系統編號 { get; set; }

    public int 物品檢驗項目編號 { get; set; }

    public string 檢驗方法 { get; set; } = null!;

    public string 檢驗結果 { get; set; } = null!;

    public string? 檢驗單位 { get; set; }

    public string? 檢驗最小值 { get; set; }

    public string? 審核狀態 { get; set; }
}
