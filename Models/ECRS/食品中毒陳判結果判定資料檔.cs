using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒陳判結果判定資料檔
{
    public int 陳判結果判定資料編號 { get; set; }

    public int 陳判結果類別檔編號 { get; set; }

    public int 中毒速報主表編號 { get; set; }

    public string 中毒速報案件編號 { get; set; } = null!;

    public string? 備註 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改時間 { get; set; }
}
