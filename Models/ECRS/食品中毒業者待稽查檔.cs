using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒業者待稽查檔
{
    public int 食品中毒業者待稽查檔_主鍵 { get; set; }

    public int? 業者編號 { get; set; }

    public int? 截止日期 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public int? 狀態 { get; set; }

    public int? 食品中毒攝食場所明細表_主鍵 { get; set; }

    public virtual 食品中毒攝食場所明細表? 食品中毒攝食場所明細表_主鍵Navigation { get; set; }

    public virtual 食品中毒速報主表? 食品中毒速報主表主鍵Navigation { get; set; }
}
