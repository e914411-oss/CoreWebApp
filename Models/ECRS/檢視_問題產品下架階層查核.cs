using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_問題產品下架階層查核
{
    public int? LevelNumber { get; set; }

    public int 主鍵 { get; set; }

    public string 案件編號 { get; set; } = null!;

    public string? 業者名稱 { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者鄉鎮 { get; set; }

    public string? 業者縣市_中文 { get; set; }

    public string? 業者鄉鎮_中文 { get; set; }

    public string? 業者街道 { get; set; }

    public string 業者地址 { get; set; } = null!;

    public string? 母案產品名稱 { get; set; }

    public string? 回收原因 { get; set; }

    public DateTime? 派案日期 { get; set; }

    public string? 派案日期_中文 { get; set; }

    public string? 最後異動時間 { get; set; }

    public string? 案件階層 { get; set; }

    public string? 狀態 { get; set; }

    public string? 狀態_中文 { get; set; }

    public int? 上一層主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 產品名稱 { get; set; }

    public string? 產品規格 { get; set; }

    public string? 產品名稱S { get; set; }

    public string? 產品規格S { get; set; }

    public string? 產品名稱All { get; set; }

    public string? 產品規格All { get; set; }

    public string? 協辦單位部門 { get; set; }
}
