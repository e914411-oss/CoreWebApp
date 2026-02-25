using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_涉案產品下架階層查核
{
    public int 主鍵 { get; set; }

    public string 案件階層 { get; set; } = null!;

    public int? 上一層主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 事件名稱 { get; set; }

    public string? 狀態 { get; set; }

    public string? 狀態_中文 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者鄉鎮 { get; set; }

    public string? 業者縣市_中文 { get; set; }

    public string? 業者鄉鎮_中文 { get; set; }

    public string? 業者街道 { get; set; }

    public string 業者地址 { get; set; } = null!;

    public DateTime? 派案日期 { get; set; }

    public string? 派案日期_中文 { get; set; }

    public string 產品名稱 { get; set; } = null!;

    public string 規格 { get; set; } = null!;

    public string 產品名稱S { get; set; } = null!;

    public string 規格s { get; set; } = null!;
}
