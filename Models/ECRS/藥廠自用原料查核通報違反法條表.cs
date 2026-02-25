using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥廠自用原料查核通報違反法條表
{
    public int 主鍵 { get; set; }

    public int? 藥廠自用原料查核通報主表主鍵 { get; set; }

    public int? 違反法條ID { get; set; }

    public string? 法條說明 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
