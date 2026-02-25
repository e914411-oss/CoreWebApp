using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_案件處分依食安法第四十五條處理原則資料檔
{
    public int 系統流水號 { get; set; }

    public string 違規案件編號 { get; set; } = null!;

    public int 違規案件處份類型 { get; set; }

    public int A_第28條第1項_罰鍰 { get; set; }

    public int A_第28條第2項_罰鍰 { get; set; }

    public int A_罰鍰 { get; set; }

    public int B_倍數 { get; set; }

    public int C_倍數 { get; set; }

    public double? D_倍數 { get; set; }

    public string? D_其它理由 { get; set; }

    public string? 罰鍰額度計算方式 { get; set; }

    public int 罰鍰額度 { get; set; }

    public int A_第28條第3項_罰鍰 { get; set; }
}
