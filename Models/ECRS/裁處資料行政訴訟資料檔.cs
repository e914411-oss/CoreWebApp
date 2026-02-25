using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處資料行政訴訟資料檔
{
    public int 行政訴訟系統編號 { get; set; }

    public int 裁處資料主檔編號 { get; set; }

    public int 行政訴訟機關 { get; set; }

    public DateOnly? 判決書發文日期 { get; set; }

    public string? 判決書發文字號_字 { get; set; }

    public string? 判決書發文字號_號 { get; set; }

    public string? 訴訟結果_撤銷原處分 { get; set; }

    public string? 訴訟結果_另為適法處分 { get; set; }

    public string? 訴訟結果_維持原處分 { get; set; }

    public string? 訴訟結果_撤銷訴願決定 { get; set; }

    public string? 訴訟結果_其他 { get; set; }

    public string? 訴訟結果_其他內容 { get; set; }
}
