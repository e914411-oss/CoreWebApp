using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 介接_物品檢驗結果表
{
    public int 物品檢驗編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 檢查件數 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗結果值 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 檢驗系統結果判定 { get; set; }
}
