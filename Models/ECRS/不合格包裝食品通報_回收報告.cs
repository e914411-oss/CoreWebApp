using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 不合格包裝食品通報_回收報告
{
    public int 不合格包裝食品通報_回收報告_主鍵 { get; set; }

    public int? 不合格包裝食品通報_主表_主鍵 { get; set; }

    public DateOnly? 回收下架_開始時間 { get; set; }

    public DateOnly? 回收下架_結束時間 { get; set; }

    public string? 回收下架_數量 { get; set; }

    public string? 回收下架_單位代碼 { get; set; }

    public string? 回收下架_作業縣市 { get; set; }
}
