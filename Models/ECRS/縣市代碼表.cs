using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 縣市代碼表
{
    public string 縣市編號 { get; set; } = null!;

    public string? 縣市名稱 { get; set; }

    public string? 刪除註記 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 複查負責人註記 { get; set; }

    public bool? 是否區隊長需要 { get; set; }

    public virtual ICollection<食品中毒攝食場所明細表> 食品中毒攝食場所明細表s { get; set; } = new List<食品中毒攝食場所明細表>();
}
