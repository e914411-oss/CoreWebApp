using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP肉品來源代碼檔
{
    public int 肉品來源編號 { get; set; }

    public string 肉品來源查核項目名稱 { get; set; } = null!;

    public string? 是否開啟 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 異動人員 { get; set; }
}
