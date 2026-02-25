using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 報表資訊
{
    public int 編號 { get; set; }

    public string 報表編號 { get; set; } = null!;

    public string 報表名稱 { get; set; } = null!;

    public string 是否啟用 { get; set; } = null!;

    public int? 排序 { get; set; }

    public string? 管轄部門 { get; set; }

    public string? 部門電話 { get; set; }

    public string? 管轄人員 { get; set; }

    public string? 管轄人員電話 { get; set; }

    public string? 備註 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 報表類型 { get; set; }
}
