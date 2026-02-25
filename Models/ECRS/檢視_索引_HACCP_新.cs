using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_HACCP_新
{
    public int HACCP稽查主表主鍵 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? 業別主分類名稱 { get; set; }

    public string? 業別次分類主鍵 { get; set; }

    public string? 業別次分類名稱 { get; set; }

    public string? 地址 { get; set; }

    public string? 負責人姓名 { get; set; }

    public string? 稽查縣市主鍵 { get; set; }

    public string? 電話 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public DateOnly? 限定完成日 { get; set; }

    public int 索引主鍵 { get; set; }

    public string? 索引名稱 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 承辦人員名稱 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public string? 衛生專職人員 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 複查日期 { get; set; }

    public string? 營業地址_縣市主鍵 { get; set; }

    public string? 營業地址_鄉鎮區主鍵 { get; set; }

    public string? 營業地址_街道 { get; set; }
}
