using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_移入移出案件查詢
{
    public int 移外事件主鍵 { get; set; }

    public string? 來源事件種類 { get; set; }

    public int 來源事件代碼 { get; set; }

    public string? 移出縣市名稱編號 { get; set; }

    public string? 移出縣市名稱 { get; set; }

    public string? 移入縣市名稱編號 { get; set; }

    public string? 移入縣市名稱 { get; set; }

    public string? 函送日期 { get; set; }

    public DateTime? 函送日期_西元 { get; set; }

    public string? 函送文號 { get; set; }

    public string? 移入市招名稱 { get; set; }

    public string? 移出市招名稱 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 移出狀態 { get; set; }

    public string? 結案日期 { get; set; }

    public string 移出案件狀態 { get; set; } = null!;

    public string? 退回原因 { get; set; }

    public string? 是否行政處分 { get; set; }

    public string? 處理情形 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 業者地址 { get; set; }

    public string? 作業負責人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public DateTime? 移出日期 { get; set; }
}
