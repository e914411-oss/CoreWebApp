using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品郵購買賣形式選單
{
    public int 買賣形式ID { get; set; }

    public string 買賣形式名稱 { get; set; } = null!;

    public string 啟用 { get; set; } = null!;

    public int 排序 { get; set; }

    public string 是否要顯示填寫備註欄位 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;
}
