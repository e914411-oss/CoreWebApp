using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_回收報告_作業地區
{
    public int 不合格包裝食品通報_回收報告_作業地區_主鍵 { get; set; }

    public int? 不合格包裝食品通報_主表_主鍵 { get; set; }

    public string? 回收下架_作業縣市 { get; set; }

    public string? 結案狀態 { get; set; }
}
