using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查_搜尋清單
{
    public string? Signboard_Name { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string? Business_Address { get; set; }

    public string? Telephone { get; set; }

    public string? Responsible_Person_Name { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public int 物品稽查編號 { get; set; }

    public string? CheckType { get; set; }

    public string? 食品地區別 { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 物品編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 國曆物品有效日期 { get; set; }

    public string? 製造商名稱 { get; set; }

    public string? 製造商電話 { get; set; }

    public string? 製造商地址 { get; set; }

    public string? 來源商名稱 { get; set; }

    public string? 來源商電話 { get; set; }

    public string? 來源商地址 { get; set; }

    public string? 標示產地 { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? 原產地證明 { get; set; }

    public string? 抽驗_違規件數 { get; set; }

    public string? 抽驗_稽查件數 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? SENDCHK { get; set; }

    public string? FINISHED { get; set; }

    public string? FMS國曆結案日期 { get; set; }

    public string? 產品別主分類名稱 { get; set; }

    public string? 產品別次分類名稱 { get; set; }

    public string? 產品別細分類名稱 { get; set; }

    public string? FMS備註 { get; set; }

    public string? 抽驗稽查 { get; set; }

    public string? 熟食稽查 { get; set; }

    public string? 標示稽查 { get; set; }
}
