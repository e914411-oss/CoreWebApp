using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_逾期2個月外縣市移入未處理
{
    public int 主鍵 { get; set; }

    public string? 移入縣市名稱編號 { get; set; }

    public string? 縣市 { get; set; }

    public DateTime? 移入日期 { get; set; }

    public string? 稽查項目 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 地址 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 函送文號 { get; set; }

    public string? 函送日期 { get; set; }

    public string? 移外縣市 { get; set; }

    public string? 案件所在階段 { get; set; }

    public string? 案件所在人員 { get; set; }

    public string? 案件所在人員帳號 { get; set; }

    public string? 縣市代號 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public int? 來源事件代碼 { get; set; }

    public string? 推播 { get; set; }

    public DateTime? 登打日期 { get; set; }
}
