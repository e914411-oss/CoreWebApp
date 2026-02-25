using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品抽驗_稽查主檔業者資料對應
{
    public int 物品抽驗編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? 物品名稱 { get; set; }

    public string? ORG { get; set; }

    public string? Create_ID { get; set; }

    public string? Del_MK { get; set; }

    public string? 作業負責人員 { get; set; }

    public string? 作業階段 { get; set; }
}
