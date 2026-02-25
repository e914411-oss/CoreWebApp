using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_食品中毒_攝食場所類別
{
    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 攝食場所類別代碼 { get; set; }

    public string 攝食場所類別代碼名稱 { get; set; } = null!;

    public int? 學校供餐類型 { get; set; }

    public string? 學校供餐類型_其他說明 { get; set; }
}
