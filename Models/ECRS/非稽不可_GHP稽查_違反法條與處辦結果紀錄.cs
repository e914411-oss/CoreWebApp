using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_GHP稽查_違反法條與處辦結果紀錄
{
    public int GHP稽查編號 { get; set; }

    public string? 業者主類別代碼 { get; set; }

    public int? 稽查事件流水編號 { get; set; }

    public string? 縣市代碼檔 { get; set; }

    public DateOnly? 稽查日期 { get; set; }

    public string? 稽查日期_民國年_ { get; set; }

    public string? 專案名稱代碼 { get; set; }

    public string? 專案名稱 { get; set; }

    public string? 現場稽查描述 { get; set; }

    public string? 廚證人數 { get; set; }

    public string? 工作人數 { get; set; }

    public string? 烹飪證照丙級人數 { get; set; }

    public string? 烹飪證照乙級人數 { get; set; }

    public string? 稽查結果_合格 { get; set; }

    public string? 稽查結果_輔導改善 { get; set; }

    public string? 稽查結果_限期改善日期 { get; set; }

    public string? 稽查結果_複查合格_ { get; set; }

    public string? 稽查結果_複查不合格 { get; set; }

    public string? 稽查結果_移縣市辦理 { get; set; }

    public string? 稽查結果_停_廢_歇業 { get; set; }

    public string? 稽查結果_停_廢_歇業型態 { get; set; }

    public string? 稽查結果_罰款金額 { get; set; }

    public string? 稽查結果_移送法院處理_ { get; set; }

    public string? 稽查結果_其他 { get; set; }

    public string? 稽查結果_不合格 { get; set; }

    public string? 稽查結果 { get; set; }

    public string? 稽查結果代碼 { get; set; }

    public string? 結案註記 { get; set; }

    public string? 產品責任保險 { get; set; }

    public DateOnly? 保險期間開始年月日 { get; set; }

    public DateOnly? 保險期間結束年月日 { get; set; }

    public string? 保險期間開始民國年月日 { get; set; }

    public string? 保險期間結束民國年月日 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 異動日期_民國年_ { get; set; }

    public string? 案件階段 { get; set; }

    public string? 案件負責人 { get; set; }

    public string? 違反法條_食品衛生管理法第二十條第一項_ { get; set; }

    public string? 罰鍰金額 { get; set; }

    public string? 備註說明 { get; set; }

    public string? 處理情形_停業 { get; set; }

    public string? 處理情形_移送法院 { get; set; }

    public string? 稽查人員ID { get; set; }

    public string? 承辦人員ID { get; set; }

    public string? 審查人員ID { get; set; }

    public string? 結案日期 { get; set; }

    public int? 複查編號 { get; set; }

    public int? 複查次數 { get; set; }

    public int? 稽查編號 { get; set; }

    public string? 備註 { get; set; }

    public string? 介面異動者 { get; set; }

    public string? 業者次類別代碼 { get; set; }

    public string? 廚師人數 { get; set; }

    public string? 從業人員_兼職_ { get; set; }

    public string? 配合其他單位主管機關執行聯合稽查_ { get; set; }

    public string? 從業人員_正職_ { get; set; }

    public string? 正職體檢人數 { get; set; }

    public string? 兼職體檢人數 { get; set; }

    public string? 食品安全衛生管理法第十三條 { get; set; }

    public int? 產品標示符合性稽查_查核件數 { get; set; }

    public string? 產品標示符合性稽查_稽查結果 { get; set; }

    public string? 產品標示符合性稽查_不符合情形___________ { get; set; }

    public string? 單方食品添加物__稽查結果 { get; set; }

    public string? 單方食品添加物_不符合情形_ { get; set; }

    public string? 複方食品添加物__稽查結果 { get; set; }

    public string? 複方食品添加物_不符合情形 { get; set; }

    public string? 所使用食品添加物其製造或進口廠商是否登錄 { get; set; }

    public string? 所使用食品添加物其製造或進口廠商是否登錄_不符合情形 { get; set; }

    public string? 產品標示符合性稽查_後續處半結果 { get; set; }

    public string? 產品標示符合性稽查_該廠產製產品品項簡述 { get; set; }

    public string? 食品業者運輸畜禽屠體_內臟及其分切物之衛生查核 { get; set; }

    public string? 自行載運載運或委託載運載運 { get; set; }

    public string? 自行載運載運司機姓名 { get; set; }

    public string? 自行載運載運車牌號碼 { get; set; }

    public string? 自行載運載運查核結果 { get; set; }

    public string? 委託載運 { get; set; }

    public string? 委託業者名稱 { get; set; }

    public string? 委託業者電話 { get; set; }

    public string? 委託載運載運司機姓名 { get; set; }

    public string? 委託載運載運車牌號碼 { get; set; }

    public string? 委託載運載運地址 { get; set; }

    public string? 委託載運載運查核結果 { get; set; }

    public string? _屠宰業者或其委託運輸業者_載運業者名稱 { get; set; }

    public string? _屠宰業者或其委託運輸業者_地址 { get; set; }

    public string? _屠宰業者或其委託運輸業者_電話 { get; set; }

    public string? _屠宰業者或其委託運輸業者_司機姓名 { get; set; }

    public string? _屠宰業者或其委託運輸業者_車牌號碼 { get; set; }

    public string? 備註1 { get; set; }

    public DateOnly? 登打日期 { get; set; }

    public string? 登打日期與稽查日期相差七日案件通知 { get; set; }
}
