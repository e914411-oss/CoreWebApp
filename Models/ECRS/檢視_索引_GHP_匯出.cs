using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_索引_GHP_匯出
{
    public int GHP稽查主表主鍵 { get; set; }

    public string? 稽查業別 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? 業別主分類名稱 { get; set; }

    public string? 業別次分類主鍵 { get; set; }

    public string? 業別次分類名稱 { get; set; }

    public string? 縣市名稱 { get; set; }

    public string? 鄉鎮區名稱 { get; set; }

    public string? 營業地址_街道 { get; set; }

    public string? 負責人姓名 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 稽查結果_停廢歇業類別 { get; set; }

    public string? 稽查縣市主鍵 { get; set; }

    public string? 電話 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public DateOnly? 限定完成日 { get; set; }

    public int? 業者主鍵 { get; set; }

    public string? 稽查人員名稱 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public DateTime? 前一次稽查日期 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 前一次稽查結果_停廢歇業類別 { get; set; }

    public string? 前一次稽查結果 { get; set; }

    public string? 前一次稽查結果代碼 { get; set; }

    public string? 單位 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? 受稽查廠商業別分類 { get; set; }

    public string? 配合其他單位主管機關執行聯合稽查 { get; set; }

    public string? 廚師人數 { get; set; }

    public string? 國曆產品責任保險起始日期 { get; set; }

    public string? 國曆產品責任保險迄止日期 { get; set; }

    public string? 從業人員 { get; set; }

    public string? 廚證人數 { get; set; }

    public string? 烹飪證照丙級人數 { get; set; }

    public string? 烹飪證照乙級人數 { get; set; }

    public string? 產品責任保險 { get; set; }

    public string 產品責任保險日期 { get; set; } = null!;

    public string 持證比例 { get; set; } = null!;

    public string? FMS介接主鍵 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 處理情形 { get; set; }

    public string? 產品標示符合性稽查_後續處辦情形 { get; set; }

    public string? 食品添加物使用與管理_未登錄廠商名稱 { get; set; }

    public string? 食品添加物使用與管理_所使用食品添加物其製造或進口廠商是否登錄 { get; set; }

    public string? 食品添加物使用與管理_複方食品添加物不符合情形 { get; set; }

    public string? 食品添加物使用與管理_複方食品添加物稽查結果 { get; set; }

    public string? 食品添加物使用與管理_單方食品添加物不符合情形 { get; set; }

    public string? 食品添加物使用與管理_單方食品添加物稽查結果 { get; set; }

    public string? 產品標示符合性稽查_不符合情形 { get; set; }

    public string? 產品標示符合性稽查_稽查結果 { get; set; }

    public int? 產品標示符合性稽查_查核件數 { get; set; }

    public string? 產品標示符合性稽查_該廠產製產品品項簡述 { get; set; }

    public string? 屠體內臟及其分切物載運器具衛生查核_備註 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_車牌號碼 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_司機姓名 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_地址 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_電話 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_屠宰業者或其委託運輸業者名稱 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_車牌號碼 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_查核結果 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_司機姓名 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_查核結果 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_車牌號碼 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_司機姓名 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運 { get; set; }

    public string? 屠體內臟及其分切物載運器具衛生查核 { get; set; }

    public string? 肉品來源查核結果名稱 { get; set; }

    public string? 承辦人員名稱 { get; set; }

    public string? 審查人員名稱 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public int? 衛生管理人員 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 商業登記名稱 { get; set; }

    public string? 食品業者登錄字號 { get; set; }

    public int? 稽查序號 { get; set; }

    public int? 前一次稽查序號 { get; set; }

    public string? 是否為複查 { get; set; }
}
