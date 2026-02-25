using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒_食物腐敗原因
{
    public int 食品中毒速報主表主鍵 { get; set; }

    public string? 導致食物腐敗原因代碼 { get; set; }

    public string 導致食物腐敗原因名稱 { get; set; } = null!;
}
