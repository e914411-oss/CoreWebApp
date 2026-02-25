using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 系統_預警通知_GHP
{
    public int 主鍵 { get; set; }

    public DateTime? 系統_日期 { get; set; }

    public string? 種類 { get; set; }

    public string? 縣市 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 地址 { get; set; }

    public string? 稽查日期 { get; set; }

    public string? 限改日期 { get; set; }

    public string? 稽查員 { get; set; }

    public string? 推播 { get; set; }

    public string? 逾期天數 { get; set; }

    public string? 案件所在階段 { get; set; }

    public string? 案件所在人員 { get; set; }

    public string? 案件所在人員帳號 { get; set; }
}
