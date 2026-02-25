using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 回收後續處理情形稽查附件_醫療器材_ForQM
{
    public int 醫療器材回收處理編號 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }
}
