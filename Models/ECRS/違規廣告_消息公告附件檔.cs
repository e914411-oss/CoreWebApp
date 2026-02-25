using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 違規廣告_消息公告附件檔
{
    public int 公告附件編號 { get; set; }

    public int 公告編號 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public string? 檔案類型 { get; set; }

    public byte[]? 檔案內容 { get; set; }

    public DateTime? 修改日期 { get; set; }

    public string? 修改人員 { get; set; }
}
