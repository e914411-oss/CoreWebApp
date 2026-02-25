using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP稽查主表_20250221
{
    public int 主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public int? 稽查事件主鍵 { get; set; }

    public string? 稽查縣市主鍵 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 國曆稽查日期 { get; set; }

    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 光度_工作台面米燭光 { get; set; }

    public string? 光度_烹調台面米燭光 { get; set; }

    public string? 光度_一般區域米燭光 { get; set; }

    public string? 溫度_冷藏 { get; set; }

    public string? 溫度_凍藏 { get; set; }

    public string? 溫度_熱藏 { get; set; }

    public string? 食品標示稽查_一般食品 { get; set; }

    public string? 食品標示稽查_食品添加物 { get; set; }

    public string? 食品標示稽查_食品洗潔劑 { get; set; }

    public string? 食品標示稽查_食品器具容器 { get; set; }

    public string? 食品標示稽查_合計 { get; set; }

    public string? 食品標示稽查_合格 { get; set; }

    public string? 食品標示稽查_不合格 { get; set; }

    public string? 執行衛生自主管理 { get; set; }

    public string? 執行自行檢驗 { get; set; }

    public string? 廚證人數 { get; set; }

    public string? 從業人員 { get; set; }

    public string? 烹飪證照丙級人數 { get; set; }

    public string? 烹飪證照乙級人數 { get; set; }

    public string? 稽查結果_合格 { get; set; }

    public string? 稽查結果_輔導改善 { get; set; }

    public string? 稽查結果_限期改善日期 { get; set; }

    public string? 稽查結果_複查合格 { get; set; }

    public string? 稽查結果_複查不合格 { get; set; }

    public string? 稽查結果_移縣市辦理 { get; set; }

    public string? 稽查結果_停廢歇業 { get; set; }

    public string? 稽查結果_停廢歇業類別 { get; set; }

    public string? 稽查結果_罰款金額 { get; set; }

    public string? 稽查結果_移送法院處理 { get; set; }

    public string? 稽查結果_其他 { get; set; }

    public string? 稽查結果_不合格 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? FMS稽查人員主鍵 { get; set; }

    public string? FMS承辦人員主鍵 { get; set; }

    public string? FMS審查人員主鍵 { get; set; }

    public string? 作業階段FMS { get; set; }

    public string? 結案狀態 { get; set; }

    public string? FMS結案日期 { get; set; }

    public string? 產品責任保險 { get; set; }

    public DateOnly? 產品責任保險起始日期 { get; set; }

    public DateOnly? 產品責任保險迄止日期 { get; set; }

    public string? 國曆產品責任保險起始日期 { get; set; }

    public string? 國曆產品責任保險迄止日期 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 國曆異動日期 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 違反法條_食品安全衛生管理法第八條第一項 { get; set; }

    public string? 處理情形_罰鍰金額 { get; set; }

    public string? 承辦備註 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查事件編號 { get; set; }

    public string? 未使用可刪除1 { get; set; }

    public string? 未使用可刪除2 { get; set; }

    public string? 未使用可刪除3 { get; set; }

    public string? 稽查備註 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 第一次稽查衛生局稽查系統主鍵 { get; set; }

    public string? 前次稽查衛生局稽查系統主鍵 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public string? 業別次分類主鍵 { get; set; }

    public string? 廚師人數 { get; set; }

    public string? 體檢情形_兼職從業人員 { get; set; }

    public string? 配合其他單位主管機關執行聯合稽查 { get; set; }

    public string? 體檢情形_正職從業人員 { get; set; }

    public string? 體檢情形_正職體檢人數 { get; set; }

    public string? 體檢情形_兼職體檢人數 { get; set; }

    public string? 違反法條_食品安全衛生管理法第十三條 { get; set; }

    public int? 產品標示符合性稽查_查核件數 { get; set; }

    public string? 產品標示符合性稽查_稽查結果 { get; set; }

    public string? 產品標示符合性稽查_不符合情形 { get; set; }

    public string? 食品添加物使用與管理_單方食品添加物稽查結果 { get; set; }

    public string? 食品添加物使用與管理_單方食品添加物不符合情形 { get; set; }

    public string? 食品添加物使用與管理_複方食品添加物稽查結果 { get; set; }

    public string? 食品添加物使用與管理_複方食品添加物不符合情形 { get; set; }

    public string? 食品添加物使用與管理_所使用食品添加物其製造或進口廠商是否登錄 { get; set; }

    public string? 食品添加物使用與管理_未登錄廠商名稱 { get; set; }

    public string? 產品標示符合性稽查_後續處辦情形 { get; set; }

    public string? 產品標示符合性稽查_該廠產製產品品項簡述 { get; set; }

    public string? 屠體內臟及其分切物載運器具衛生查核 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_司機姓名 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_車牌號碼 { get; set; }

    public string? 食品業者或其委託運輸業者載運_自行載運_查核結果 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_委託業者名稱 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_電話 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_司機姓名 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_車牌號碼 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_地址 { get; set; }

    public string? 食品業者或其委託運輸業者載運_委託載運_查核結果 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_屠宰業者或其委託運輸業者名稱 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_地址 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_電話 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_司機姓名 { get; set; }

    public string? 屠宰業者或其委託運輸業者載運_車牌號碼 { get; set; }

    public string? 屠體內臟及其分切物載運器具衛生查核_備註 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 登打日與稽查日超過七日通知 { get; set; }

    public byte[]? APP稽查產生的PDF檔案 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public bool? 本案件由APP建立 { get; set; }

    public int? 衛生管理人員 { get; set; }

    public string? 承辦意見 { get; set; }

    public string? 稽查結果_不適用 { get; set; }
}
