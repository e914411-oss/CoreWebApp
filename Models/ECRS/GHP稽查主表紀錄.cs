using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class GHP稽查主表紀錄
{
    public int 完成主鍵 { get; set; }

    /// <summary>
    /// GHP ID (GHP稽查主檔)
    /// </summary>
    public int? 主鍵 { get; set; }

    public string? 業別主分類主鍵 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接主鍵 { get; set; }

    /// <summary>
    /// Check_List_ID
    /// </summary>
    public int? 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 縣市代碼檔
    /// </summary>
    public string? 稽查縣市主鍵 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public DateOnly? 稽查日期 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public string? 國曆稽查日期 { get; set; }

    /// <summary>
    /// 記錄專案名稱的ID,用逗號分隔
    /// </summary>
    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

    /// <summary>
    /// 現場稽查描述
    /// </summary>
    public string? 現場稽查描述 { get; set; }

    /// <summary>
    /// 光度：工作台面(米燭光)
    /// </summary>
    public string? 光度_工作台面米燭光 { get; set; }

    /// <summary>
    /// 光度：烹調台面(米燭光)
    /// </summary>
    public string? 光度_烹調台面米燭光 { get; set; }

    /// <summary>
    /// 光度：一般區域(米燭光)
    /// </summary>
    public string? 光度_一般區域米燭光 { get; set; }

    /// <summary>
    /// 溫度：冷藏(℃)
    /// </summary>
    public string? 溫度_冷藏 { get; set; }

    /// <summary>
    /// 溫度：凍藏(℃)
    /// </summary>
    public string? 溫度_凍藏 { get; set; }

    /// <summary>
    /// 溫度：熱藏(℃)
    /// </summary>
    public string? 溫度_熱藏 { get; set; }

    /// <summary>
    /// 食品標示稽查:：一般食品(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_一般食品 { get; set; }

    /// <summary>
    /// 食品標示稽查:：食品添加物(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_食品添加物 { get; set; }

    /// <summary>
    /// 食品標示稽查:：食品洗潔劑(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_食品洗潔劑 { get; set; }

    /// <summary>
    /// 食品標示稽查:：食品器具容器(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_食品器具容器 { get; set; }

    /// <summary>
    /// 食品標示稽查:：合計(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_合計 { get; set; }

    /// <summary>
    /// 食品標示稽查:：合格(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_合格 { get; set; }

    /// <summary>
    /// 食品標示稽查:：不合格(不需寫回FMS)
    /// </summary>
    public string? 食品標示稽查_不合格 { get; set; }

    /// <summary>
    /// 執行衛生自主管理 y/n
    /// </summary>
    public string? 執行衛生自主管理 { get; set; }

    /// <summary>
    /// 執行自行檢驗 y/n
    /// </summary>
    public string? 執行自行檢驗 { get; set; }

    /// <summary>
    /// 辦理廚證人數,畫面上不需要此欄位，但table先開此欄位
    /// </summary>
    public string? 廚證人數 { get; set; }

    /// <summary>
    /// 從業人數,畫面上不需要此欄位，但table先開此欄位
    /// </summary>
    public string? 從業人員 { get; set; }

    /// <summary>
    /// 烹飪證照丙級人數
    /// </summary>
    public string? 烹飪證照丙級人數 { get; set; }

    /// <summary>
    /// 烹飪證照乙級人數
    /// </summary>
    public string? 烹飪證照乙級人數 { get; set; }

    /// <summary>
    /// 稽查結果-合格 y/n
    /// </summary>
    public string? 稽查結果_合格 { get; set; }

    /// <summary>
    /// 稽查結果-輔導改善 y/n
    /// </summary>
    public string? 稽查結果_輔導改善 { get; set; }

    /// <summary>
    /// 稽查結果-限期改善日期 y/n
    /// </summary>
    public string? 稽查結果_限期改善日期 { get; set; }

    /// <summary>
    /// 稽查結果-複查合格 y/n
    /// </summary>
    public string? 稽查結果_複查合格 { get; set; }

    /// <summary>
    /// 稽查結果-複查不合格 y/n
    /// </summary>
    public string? 稽查結果_複查不合格 { get; set; }

    /// <summary>
    /// 稽查結果-移縣市辦理 y/n
    /// </summary>
    public string? 稽查結果_移縣市辦理 { get; set; }

    /// <summary>
    /// 稽查結果-停、廢、歇業,對方table char(1)，是用於記錄y/n，也就是僅記錄是否停、廢、歇業
    /// </summary>
    public string? 稽查結果_停廢歇業 { get; set; }

    /// <summary>
    /// 稽查結果-停、廢、歇業,我們系統要用的char(1)，用於記錄停:1、廢:2、歇業:3
    /// </summary>
    public string? 稽查結果_停廢歇業類別 { get; set; }

    /// <summary>
    /// 稽查結果-罰款金額,  畫面上不需要此欄位，但table先開此欄位 y/n
    /// </summary>
    public string? 稽查結果_罰款金額 { get; set; }

    /// <summary>
    /// 稽查結果-移送法院處理,畫面上不需要此欄位，但table先開此欄位 y/n
    /// </summary>
    public string? 稽查結果_移送法院處理 { get; set; }

    /// <summary>
    /// 稽查結果-其他
    /// </summary>
    public string? 稽查結果_其他 { get; set; }

    /// <summary>
    /// 稽查結果-不合格,畫面上不需要此欄位，但table先開此欄位 y/n
    /// </summary>
    public string? 稽查結果_不合格 { get; set; }

    /// <summary>
    /// 稽查結果-整體結果(將稽查結果記錄此欄位以便查詢)
    /// </summary>
    public string? 稽查結果 { get; set; }

    /// <summary>
    /// 稽查結果-整體結果代碼(7要搭配RES7_TYPE)
    /// </summary>
    public string? 稽查結果代碼 { get; set; }

    /// <summary>
    /// 稽查人員,以新增稽查作業的人員ID寫回此欄位
    /// </summary>
    public string? FMS稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦人員,以新增稽查作業的人員ID寫回此欄位
    /// </summary>
    public string? FMS承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審核員
    /// </summary>
    public string? FMS審查人員主鍵 { get; set; }

    /// <summary>
    /// 作業階段,分為1：稽查員2：承辦員3：審查員4：任務派送中
    /// </summary>
    public string? 作業階段FMS { get; set; }

    /// <summary>
    /// 結案狀態,分為已結案,未結案 分為Y:已結案,N:未結案
    /// </summary>
    public string? 結案狀態 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public string? FMS結案日期 { get; set; }

    /// <summary>
    /// 產品責任保險(單選: 1.合格 2.複查合格 3.限期改善 4.非規範對象 5.依法處分)
    /// </summary>
    public string? 產品責任保險 { get; set; }

    /// <summary>
    /// 保險期間開始年月日
    /// </summary>
    public DateOnly? 產品責任保險起始日期 { get; set; }

    /// <summary>
    /// 保險期間結束年月日
    /// </summary>
    public DateOnly? 產品責任保險迄止日期 { get; set; }

    /// <summary>
    /// 保險期間開始民國年月日
    /// </summary>
    public string? 國曆產品責任保險起始日期 { get; set; }

    /// <summary>
    /// 保險期間結束民國年月日
    /// </summary>
    public string? 國曆產品責任保險迄止日期 { get; set; }

    /// <summary>
    /// 異動日期時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動日期民國年月日
    /// </summary>
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

    public string? 產品標示符合性稽查_查核件數 { get; set; }

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

    public string? 異動原因 { get; set; }

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

    public string? 稽查結果_不適用 { get; set; }
}
