using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 裁處專區_附件檔
{
    public int 主鍵 { get; set; }

    public int 裁處行政處分主表主鍵 { get; set; }

    public string? 檔案所屬區塊 { get; set; }

    public string? 上傳人員 { get; set; }

    public DateTime? 上傳日期 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public string 檔案類型 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;
}
