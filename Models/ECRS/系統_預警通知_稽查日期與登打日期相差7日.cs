using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_稽查日期與登打日期相差7日
{
    public int 主鍵 { get; set; }

    public string? 縣市 { get; set; }

    public string? 稽查項目 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 地址 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 稽查員 { get; set; }

    public string? 稽查員帳號 { get; set; }

    public string? 縣市代號 { get; set; }

    public string? 推播 { get; set; }

    public string? 登打日期 { get; set; }
}
