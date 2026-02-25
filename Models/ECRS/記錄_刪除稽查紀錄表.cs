using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_刪除稽查紀錄表
{
    public int 刪除編號 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public int? 業者編號 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 稽查項目 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 刪除人員編號 { get; set; }

    public string? 刪除人員姓名 { get; set; }

    public DateTime? 刪除時間 { get; set; }
}
