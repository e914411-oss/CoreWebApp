using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料行政訴願資料檔
{
    public int 行政訴願系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public DateOnly? 訴願受理日期 { get; set; }

    public DateOnly? 訴願決定書發文日期 { get; set; }

    public string? 訴願決定書發文字號_字 { get; set; }

    public string? 訴願決定書發文字號_號 { get; set; }

    public int? 訴願發文機關 { get; set; }

    public string? 訴願結果_撤銷原處分 { get; set; }

    public string? 訴願結果_另為適法處分 { get; set; }

    public string? 訴願結果_維持原處分 { get; set; }

    public string? 訴願結果_機構自行撤銷 { get; set; }

    public string? 訴願結果_其他 { get; set; }

    public string? 訴願結果_其他內容 { get; set; }
}
