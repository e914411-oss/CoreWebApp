using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品檢驗_業者資料對應
{
    public int 物品檢驗編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 檢查件數 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    public string? 檢驗結果值 { get; set; }

    public string? 檢驗結果 { get; set; }

    public string? 檢驗系統結果判定 { get; set; }

    public int? Industry_ID { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? EMail { get; set; }

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }
}
