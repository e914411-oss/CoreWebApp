using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 稽查項目與稽查結果附件對應檔
{
    public int 流水號 { get; set; }

    public int 稽查項目ID { get; set; }

    public int 稽查結果附件類別ID { get; set; }

    public bool 是否啟用 { get; set; }

    public string? 備註 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
