using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_違規廣告_處分案件
{
    public string 違規案件編號 { get; set; } = null!;

    public string 處分進度 { get; set; } = null!;

    public string 處分機關 { get; set; } = null!;

    public string 處分縣市 { get; set; } = null!;

    public string 違規事實 { get; set; } = null!;

    public string 違規廠商 { get; set; } = null!;

    public string 負責人 { get; set; } = null!;

    public DateTime 處分日期 { get; set; }

    public string? 處分法條 { get; set; }

    public int 處分金額 { get; set; }

    public string? 罰款分配 { get; set; }

    public string? 處分字號 { get; set; }

    public string 違規內容 { get; set; } = null!;

    public string? 受處罰媒體 { get; set; }

    public int 查處情形 { get; set; }

    public string? 查處情形_輔導文號 { get; set; }

    public string? 查處情形_已處分文號 { get; set; }

    public string? 查處情形_其他備註 { get; set; }

    public DateTime? 查處情形_處分日期 { get; set; }

    public string? 查處情形_媒體提供託播業者資料 { get; set; }

    public string? 移查單位 { get; set; }

    public DateTime? 移查日期 { get; set; }

    public string 註銷註記 { get; set; } = null!;

    public string 建立者帳號 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }

    public string 修改者帳號 { get; set; } = null!;

    public DateTime 修改時間 { get; set; }

    public string? 發文文號 { get; set; }

    public DateTime? 進行案件函詢_發文日期 { get; set; }

    public DateTime? 進行案件函詢_函詢完成日 { get; set; }

    public string? 結案文號 { get; set; }

    public string? 組織流水號 { get; set; }

    public string? 平面媒體類型 { get; set; }

    public string? 產品類別 { get; set; }

    public int? 案件進度 { get; set; }

    public string? 案件來源機關 { get; set; }

    public string? 媒體類型 { get; set; }

    public DateTime? 業者_處分日期 { get; set; }

    public DateTime? 代言人_處分日期 { get; set; }

    public DateTime? 傳播媒體_處分日期 { get; set; }
}
