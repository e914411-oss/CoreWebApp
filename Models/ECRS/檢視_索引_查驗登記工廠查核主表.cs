using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_查驗登記工廠查核主表
{
    public string? 申請商或國內製造廠分裝廠代碼 { get; set; }

    public string? 國內製造廠代碼 { get; set; }

    public string? 產品中文名稱 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 許可證字號2 { get; set; }

    public int? 健康食品主鍵 { get; set; }

    public int 查驗登記工廠查核主表主鍵 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? 業別主分類名稱 { get; set; }

    public string? 業別次分類主鍵 { get; set; }

    public string? 業別次分類名稱 { get; set; }

    public string 地址 { get; set; } = null!;

    public string? 負責人姓名 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果_停廢歇業類別 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 電話 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 限期改善日期 { get; set; }

    public int 索引主鍵 { get; set; }

    public string? 索引名稱 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 承辦人員名稱 { get; set; }

    public string? 稽查人員名稱 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public DateOnly? 複查日期 { get; set; }

    public string? 匯出1 { get; set; }

    public int? 稽查事件主鍵 { get; set; }
}
