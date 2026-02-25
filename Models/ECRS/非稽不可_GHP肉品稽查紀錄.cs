using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP肉品稽查紀錄
{
    public int 肉品稽查紀錄編號 { get; set; }

    public int GHP稽查編號 { get; set; }

    public string? 肉品來源編號 { get; set; }

    public string? 肉品來源查核結果代碼 { get; set; }

    public string 肉品來源查核結果名稱 { get; set; } = null!;

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
