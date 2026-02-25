using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 回收後續處理情形稽查附件_藥品_ForQM
{
    public int QMS藥品回收主檔編號 { get; set; }

    public int 藥品回收處理編號 { get; set; }

    public int 藥品回收處理檔案系統編號 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public DateTime 建立時間 { get; set; }
}
