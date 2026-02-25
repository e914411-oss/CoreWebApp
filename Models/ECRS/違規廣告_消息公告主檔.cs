using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_消息公告主檔
{
    public int 公告編號 { get; set; }

    public string 公告標題 { get; set; } = null!;

    public DateTime? 公告時間_起 { get; set; }

    public DateTime? 公告時間_迄 { get; set; }

    public string? 公告內容 { get; set; }

    public string? 狀態 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
