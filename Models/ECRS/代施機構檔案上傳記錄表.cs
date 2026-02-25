using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 代施機構檔案上傳記錄表
{
    public int 系統編號 { get; set; }

    public DateTime 上傳時間 { get; set; }

    public string 代施機構業者 { get; set; } = null!;

    public string 檔案名稱 { get; set; } = null!;
}
