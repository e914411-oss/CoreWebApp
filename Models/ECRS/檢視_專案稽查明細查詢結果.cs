using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_專案稽查明細查詢結果
{
    public int 申請單編號 { get; set; }

    public int? 專案編號 { get; set; }

    public string? 申請狀態 { get; set; }

    public string? 查詢縣市編號 { get; set; }

    public string? 案件狀態 { get; set; }

    public DateOnly? 稽查日期_起 { get; set; }

    public DateOnly? 稽查日期_迄 { get; set; }

    public int? 稽查項目編號 { get; set; }

    public string? 稽查項目名稱 { get; set; }

    public int 稽查ID { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 結案日期 { get; set; }
}
