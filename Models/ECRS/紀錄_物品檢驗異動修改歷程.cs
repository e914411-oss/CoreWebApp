using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_物品檢驗異動修改歷程
{
    public int 檢驗結果修改歷程紀錄編號 { get; set; }

    public int? 物品稽查編號 { get; set; }

    public int? 物品檢驗編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 檢查件數 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗結果值 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 異動人員 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public DateTime? 檢驗單位收樣日期 { get; set; }

    public string? 檢驗方式_內容 { get; set; }
}
