using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 農委會介接_農產品檢驗結果表
{
    public int 物品稽查編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 檢出品項 { get; set; }

    public string? 檢查件數 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢出值 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 結果判定 { get; set; }

    public DateOnly? 物品稽查建立日期 { get; set; }

    public DateOnly? 結案日期 { get; set; }
}
