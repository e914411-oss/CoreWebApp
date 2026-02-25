using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 涉案產品下架階層查核_主檔
{
    public int 主鍵 { get; set; }

    public string? 縣市代碼 { get; set; }

    public string? 事件名稱 { get; set; }

    public string? 狀態 { get; set; }

    public string? 業者名稱 { get; set; }

    public string? 業者縣市 { get; set; }

    public string? 業者鄉鎮 { get; set; }

    public string? 業者街道 { get; set; }

    public DateTime? 派案日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 修改人員 { get; set; }

    public DateTime? 修改日期 { get; set; }
}
