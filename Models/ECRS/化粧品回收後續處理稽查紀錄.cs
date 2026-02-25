using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品回收後續處理稽查紀錄
{
    public int 檔案編號 { get; set; }

    public int 化粧品回收處理序號 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public string? 檔案說明 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime 更新日期 { get; set; }

    public string? 更新人員 { get; set; }
}
