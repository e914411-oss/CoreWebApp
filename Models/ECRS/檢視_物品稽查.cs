using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_物品稽查
{
    public int 物品稽查編號 { get; set; }

    public string? ORG { get; set; }

    public string? External_Key_Industry_ID { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Company_Name { get; set; }

    public string? Company_Tax_ID { get; set; }

    public string? Business_Reg_ID { get; set; }

    public string? Factory_Reg_ID { get; set; }

    public string? Project_Names { get; set; }

    public string? 產品別主分類編號 { get; set; }

    public string? 產品別次分類編號 { get; set; }

    public string? 產品別細分類編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 食品地區別 { get; set; }

    public string? 原產地代碼 { get; set; }

    public string? 標示產地 { get; set; }

    public string? 原產地證明 { get; set; }

    public string? 來源商名稱 { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Business_Category_Sub_Name { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? Business_Address { get; set; }

    public string? 類別 { get; set; }

    public int 稽查主檔編號 { get; set; }

    public int IdxId { get; set; }

    public string? IdxName { get; set; }
}
