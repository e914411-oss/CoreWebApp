using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_查驗登記工廠查核主表_加強
{
    public int 查驗登記工廠查核主表主鍵 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 鄉鎮區名稱 { get; set; }

    public string? 營業地址_街道 { get; set; }

    public int 業者主鍵 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 電話 { get; set; }

    public string? 負責人姓名 { get; set; }

    public string? 工廠登記證號 { get; set; }

    public string? 單位 { get; set; }

    public string? 使用者主鍵 { get; set; }

    public string? 使用者名稱 { get; set; }

    public string? 專案名稱 { get; set; }

    public int 稽查事件主鍵 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果_停廢歇業類別 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 稽查結果_限期改善日期 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public string? 健康食品名稱 { get; set; }

    public string? 許可證字號 { get; set; }

    public string? 縣市主鍵 { get; set; }

    public string? 業別主分類名稱 { get; set; }

    public string? 複查稽查結果 { get; set; }

    public string? 複查國曆稽查日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 查驗登記工廠類型代碼 { get; set; }

    public string? 查驗登記工廠類型代碼2 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }
}
