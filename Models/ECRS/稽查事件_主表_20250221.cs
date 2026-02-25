using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 稽查事件_主表_20250221
{
    public int 稽查事件編號 { get; set; }

    public string? FMS介接編號 { get; set; }

    public string? 稽查縣市編號 { get; set; }

    public int? 業者編號 { get; set; }

    public string? FMS介接業者編號 { get; set; }

    public string? 業別主分類編號 { get; set; }

    public string? 專案名稱編號 { get; set; }

    public string? 專案名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 稽查日期時分 { get; set; }

    public string? 國曆限定完成日 { get; set; }

    public DateOnly? 限定完成日 { get; set; }

    public string? 為複查案件 { get; set; }

    public DateOnly? 複查日期 { get; set; }

    public string? 國曆複查日期 { get; set; }

    public string? 輔導日期 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 備註 { get; set; }

    public string? 受檢業者代表人 { get; set; }

    public string? 會辦人員編號 { get; set; }

    public string? 稽查人員編號 { get; set; }

    public string? 稽查人員姓名 { get; set; }

    public string? 承辦人員編號 { get; set; }

    public string? 審查人員編號 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 國曆異動日期 { get; set; }

    public DateTime? 資料傳送時間 { get; set; }

    public int? 資料狀態 { get; set; }

    public string? 建立人員編號 { get; set; }

    public string? FMS刪除註記 { get; set; }

    public string? 刪除註記 { get; set; }

    public int? 排序 { get; set; }

    public string? 稽查事件備註 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public string? 公文文號 { get; set; }

    public string? 是否為中毒轉入 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查編號 { get; set; }

    public bool? 為中毒轉入_未使用 { get; set; }

    public string? 是否為中毒轉入待處理 { get; set; }

    public string? HACCP介接編號 { get; set; }

    public string? 衛生局稽查系統編號 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 衛生局稽查事件編號 { get; set; }

    public string? 是否手機應用建立 { get; set; }

    public byte[]? 工作紀錄PDF檔案 { get; set; }

    public string? 中毒案件編號 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }
}
