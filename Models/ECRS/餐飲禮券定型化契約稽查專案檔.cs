using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 餐飲禮券定型化契約稽查專案檔
{
    public int 系統識別碼 { get; set; }

    public int 餐飲禮券定型化契約稽查序號 { get; set; }

    public int 專案ID { get; set; }

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }
}
