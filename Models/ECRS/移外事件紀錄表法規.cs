using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 移外事件紀錄表法規
{
    public int 移外事件紀錄表法規主鍵 { get; set; }

    public int 移外事件主鍵 { get; set; }

    public int? 條 { get; set; }

    public int? 項 { get; set; }

    public int? 款 { get; set; }

    public string? 法條 { get; set; }
}
