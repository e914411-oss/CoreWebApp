using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 代施機構上傳檢驗結果附件檔
{
    public int 系統編號 { get; set; }

    public int 檢驗結果系統編號 { get; set; }

    public string 物品編號 { get; set; } = null!;

    public string 檔案名稱 { get; set; } = null!;

    public byte[] 檔案內容 { get; set; } = null!;

    public DateTime 建立日期 { get; set; }

    public string? 建立人員 { get; set; }

    public string? 備註 { get; set; }

    public int? 物品稽查編號 { get; set; }

    public int? 稽查類型 { get; set; }
}
