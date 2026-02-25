using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class Poisoned_Place
{
    public int Poisoned_Place_ID { get; set; }

    public int? External_Key { get; set; }

    public int? Case_ID { get; set; }

    public string? Case_Init_Place_NAME { get; set; }

    public string? Case_Init_Place_City { get; set; }

    public string? Case_Init_Place_Address { get; set; }

    public string? Init_Place_Code_10_IDs { get; set; }

    public string? Init_Place_Code_10_Text { get; set; }

    public string? Suppliers { get; set; }

    public string? Suppliers_City_ID { get; set; }

    public string? Suppliers_Address { get; set; }

    public DateTime? Case_Place_Eat_Time { get; set; }

    public string? Case_Place_Eat_Date_ROC { get; set; }

    public string? Case_Place_Eat_Date_ROC_Time { get; set; }

    public string? Case_Init_Place_Zip { get; set; }

    public int? SupplierID { get; set; }

    public string? check_lunch_box { get; set; }

    public string? lunch_box_id { get; set; }

    public string? Status { get; set; }

    public string? Food_Class_Code_IDs { get; set; }

    public string? Food_Class_Code_Text { get; set; }

    public string? SupplyIsEatPlace { get; set; }

    public int? 攝食場所業者編號 { get; set; }

    public string? 攝食場所登錄字號 { get; set; }

    public string? 攝食場所無登錄字號原因 { get; set; }

    public int? 供應廠商業者編號 { get; set; }

    public string? 供應廠商登錄字號 { get; set; }

    public string? 供應廠商無登錄字號原因 { get; set; }

    public string? 攝食場所負責人 { get; set; }

    public string? 攝食場所聯絡電話 { get; set; }

    public string? 攝食場所統一編號 { get; set; }

    public string? 供應廠商負責人 { get; set; }

    public string? 供應廠商聯絡電話 { get; set; }

    public string? 供應廠商統一編號 { get; set; }

    public int? 學校供餐類型 { get; set; }

    public string? 學校供餐類型_其他說明 { get; set; }
}
