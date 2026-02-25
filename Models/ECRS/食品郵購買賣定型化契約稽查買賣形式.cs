using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品郵購買賣定型化契約稽查買賣形式
{
    public int 系統識別碼 { get; set; }

    public int 食品郵購買賣定型化契約稽查序號 { get; set; }

    public int 買賣形式ID { get; set; }

    public string 備註 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
