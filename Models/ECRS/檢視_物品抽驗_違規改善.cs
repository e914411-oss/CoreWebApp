using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品抽驗_違規改善
{
    public DateTime? CHKDATE { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? Signboard_Name { get; set; }

    public string? B_Main_ID { get; set; }

    public string? B_Sub_ID { get; set; }

    public string? 物品名稱 { get; set; }

    public int 稽查主檔編號 { get; set; }

    public string? 物品編號 { get; set; }

    public string? LEGAL { get; set; }

    public string? Inspectors_Name { get; set; }

    public string? Undertake_Name { get; set; }

    public int Industry_ID { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商地址 { get; set; }

    public string 檢驗項目細類別名稱 { get; set; } = null!;

    public string? RVALUE { get; set; }

    public string? Rechk { get; set; }
}
