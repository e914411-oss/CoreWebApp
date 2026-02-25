using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 餐飲禮券定型化契約稽查現場描述
{
    public int 現場描述ID { get; set; }

    public int 餐飲禮券定型化契約稽查序號 { get; set; }

    public string 描述內容 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
