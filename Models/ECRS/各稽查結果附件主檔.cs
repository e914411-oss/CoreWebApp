using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 各稽查結果附件主檔
{
    public int 稽查結果附件ID { get; set; }

    public int 稽查項目ID { get; set; }

    public string 稽查項目中文 { get; set; } = null!;

    public int 附件類別ID { get; set; }

    public string 附件類別名稱 { get; set; } = null!;

    public int 稽查事件 { get; set; }

    public int 各稽查項目對應系統編號 { get; set; }

    public string 檔案名稱 { get; set; } = null!;

    public string? 檔案類型 { get; set; }

    public byte[] 檔案內容 { get; set; } = null!;

    public string? 備註 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }

    public string? 檔案備份路徑 { get; set; }
}
