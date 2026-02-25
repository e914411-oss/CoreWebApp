using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品郵購買賣定型化契約稽查現場描述
{
    public int 現場描述ID { get; set; }

    public int 食品郵購買賣定型化契約稽查序號 { get; set; }

    public string 描述內容 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
