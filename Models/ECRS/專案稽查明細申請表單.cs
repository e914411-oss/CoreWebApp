using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 專案稽查明細申請表單
{
    public int 申請單編號 { get; set; }

    public string? 申請單位 { get; set; }

    public string? 申請人編號 { get; set; }

    public DateTime? 申請時間 { get; set; }

    public string? 申請狀態 { get; set; }

    public DateTime? 寄出時間 { get; set; }

    public string? 查詢縣市編號 { get; set; }

    public int? 專案編號 { get; set; }

    public string? 案件狀態 { get; set; }

    public DateOnly? 稽查日期_起 { get; set; }

    public DateOnly? 稽查日期_迄 { get; set; }
}
