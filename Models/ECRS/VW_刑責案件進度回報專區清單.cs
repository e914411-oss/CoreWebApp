using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class VW_刑責案件進度回報專區清單
{
    public int 主鍵 { get; set; }

    public int? 稽查案件類別 { get; set; }

    public int? 各稽查類別編號 { get; set; }

    public string? 稽查項目 { get; set; }

    public string 物品名稱 { get; set; } = null!;

    public string? 會同單位 { get; set; }

    public int? 案件狀態 { get; set; }

    public string? 案件狀態_中文 { get; set; }

    public DateTime? 結案日期 { get; set; }

    public string? 結案人員 { get; set; }

    public string? 縣市代碼 { get; set; }

    public int 稽查事件編號 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string 縣市 { get; set; } = null!;

    public string 鄉鎮區 { get; set; } = null!;

    public string Business_Address { get; set; } = null!;

    public int? 業者編號 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 業者主類編號 { get; set; }

    public string? 業者次類編號 { get; set; }

    public string? 業者主類名稱 { get; set; }

    public string? 業者次類名稱 { get; set; }

    public int 前一次業者稽查主檔ID { get; set; }

    public int 第一次業者稽查主檔ID { get; set; }

    public string Rechk { get; set; } = null!;

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? 國曆限定完成日 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 刪除註記 { get; set; }
}
