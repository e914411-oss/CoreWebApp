using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_GHP稽查一年以內限改業者清單
{
    public int? 稽查序號 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 業別主類 { get; set; }

    public string 營業地址 { get; set; } = null!;

    public string? 負責人 { get; set; }

    public string? 連絡電話 { get; set; }

    public int 業者編號 { get; set; }

    public string? 縣市代號 { get; set; }
}
