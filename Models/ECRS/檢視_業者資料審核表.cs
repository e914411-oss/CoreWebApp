using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_業者資料審核表
{
    public string? FMS介接主鍵 { get; set; }

    public int 主鍵 { get; set; }

    public string? 營業地址_縣市主鍵 { get; set; }

    public string? 營業地址_鄉鎮區主鍵 { get; set; }

    public string? City_Name { get; set; }

    public string? County_Name { get; set; }

    public string Show_Business_Address { get; set; } = null!;

    public string? 營業地址_街道 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人姓名 { get; set; }

    public DateTime? 建檔時間 { get; set; }

    public string? Expr1 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 商業登記證號 { get; set; }

    public string? 建檔人員主鍵 { get; set; }

    public string? 自行新增原因_內容 { get; set; }

    public string? 國曆建檔時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 刪除註記 { get; set; }
}
