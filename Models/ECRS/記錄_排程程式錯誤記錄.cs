using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 記錄_排程程式錯誤記錄
{
    public int 主鍵 { get; set; }

    public string 排程名稱 { get; set; } = null!;

    public string? 錯誤狀態 { get; set; }

    public string? 錯誤標題 { get; set; }

    public string? 程式碼段 { get; set; }

    public DateTime 建立日期 { get; set; }
}
