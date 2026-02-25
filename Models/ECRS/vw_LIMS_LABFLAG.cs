using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class vw_LIMS_LABFLAG
{
    public int Check_List_ID { get; set; }

    public int? 物品稽查編號 { get; set; }

    public string? ORG { get; set; }

    public string? External_Key { get; set; }

    public string? 物品編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 國曆物品有效日期 { get; set; }

    public string? IndustryEKey { get; set; }

    public string? Company_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public string? EMail { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }
}
