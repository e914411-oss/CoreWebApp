using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP檢查條文紀錄
{
    public int GHP稽查檢查條文編號 { get; set; }

    public int? GHP稽查編號 { get; set; }

    public string? 稽查項目編號 { get; set; }

    public string? 條文內容 { get; set; }

    public string? 是否合格 { get; set; }

    public string? 不合格項目備註欄 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }
}
