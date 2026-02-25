using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報記錄_豬肉統計
{
    public int 主鍵 { get; set; }

    public int 序號 { get; set; }

    public string 縣市名稱 { get; set; } = null!;

    public string 縣市代碼 { get; set; } = null!;

    public int 製造業 { get; set; }

    public int 餐飲業 { get; set; }

    public int 販售業 { get; set; }

    public int 總計 { get; set; }

    public DateTime 更新時間 { get; set; }

    public int? 製造業母數 { get; set; }

    public int? 餐飲業母數 { get; set; }

    public int? 販售業母數 { get; set; }

    public int? 母數統計 { get; set; }
}
