using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 特殊事件通報主檔_20250225
{
    public int 特殊事件通報主檔編號 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public string? 主旨 { get; set; }

    public string? 聯絡人 { get; set; }

    public string? 聯絡人電話 { get; set; }

    public string? 聯絡人Email { get; set; }

    public DateTime? 通報截止時間 { get; set; }

    public string? 是否開放上傳附件檔案 { get; set; }

    public string? 填報頻率 { get; set; }

    public string? 每週星期幾 { get; set; }

    public DateTime? 每週星期幾之開始時間 { get; set; }

    public string? 填報說明 { get; set; }

    public string? 是否開放衛生局填報 { get; set; }

    public DateTime? 更新日期 { get; set; }

    public string? 更新人員 { get; set; }

    public DateTime? 稽催時間1 { get; set; }

    public DateTime? 稽催時間2 { get; set; }

    public string? 衛生局稽查系統編號 { get; set; }

    public DateTime? 稽催開始日期 { get; set; }
}
