using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 查驗登記工廠查核主表
{
    public int 主鍵 { get; set; }

    public string? 查驗登記工廠類型代碼 { get; set; }

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
    public string? 縣市主鍵 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public DateOnly? 稽查日期 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public string? 國曆稽查日期 { get; set; }

    /// <summary>
    /// 專案名稱 
    /// </summary>
    public string? 專案名稱主鍵 { get; set; }

    public string? 專案名稱 { get; set; }

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
    /// 稽查結果 
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
    public string? FMS作業階段 { get; set; }

    /// <summary>
    /// 結案狀態,分為已結案,未結案 分為Y:已結案,N:未結案
    /// </summary>
    public string? 結案狀態 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public string? FMS國曆結案日期 { get; set; }

    /// <summary>
    /// 產品責任保險
    /// </summary>
    public string? 產品責任保險 { get; set; }

    /// <summary>
    /// 保險期間開始日 
    /// </summary>
    public DateOnly? 產品責任保險起始日期 { get; set; }

    /// <summary>
    /// 保險期間結束日 
    /// </summary>
    public DateOnly? 產品責任保險迄止日期 { get; set; }

    /// <summary>
    /// 保險期間開始日
    /// </summary>
    public string? 產品責任保險國曆起始日期 { get; set; }

    /// <summary>
    /// 保險期間結束日 
    /// </summary>
    public string? 產品責任保險國曆迄止日期 { get; set; }

    /// <summary>
    /// 異動日期時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動日期民國年月日
    /// </summary>
    public string? 異動日期_國曆 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員主鍵 { get; set; }

    public string? 違反法條 { get; set; }

    /// <summary>
    /// 罰鍰金額
    /// </summary>
    public string? 處理情形_罰鍰金額 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string? 稽查備註說明 { get; set; }

    /// <summary>
    /// 產品定期封存
    /// </summary>
    public string? 處理情形_產品定期封存 { get; set; }

    /// <summary>
    /// 產品沒入銷毀
    /// </summary>
    public string? 處理情形_產品沒入銷毀 { get; set; }

    /// <summary>
    /// 不符合事項
    /// </summary>
    public string? 不符合事項 { get; set; }

    /// <summary>
    /// 其他違反事項
    /// </summary>
    public string? 其他違反事項 { get; set; }

    /// <summary>
    /// 查核報告文號
    /// </summary>
    public string? 查核報告文號 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 國曆結案日期 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    /// <summary>
    /// 產品限期回收改正
    /// </summary>
    public string? 處理情形_產品限期回收改正 { get; set; }

    /// <summary>
    /// 歇業
    /// </summary>
    public string? 處理情形_歇業 { get; set; }

    /// <summary>
    /// 停業
    /// </summary>
    public string? 處理情形_停業 { get; set; }

    /// <summary>
    /// 廢止營業或工廠登記
    /// </summary>
    public string? 處理情形_廢止營業或工廠登記 { get; set; }

    /// <summary>
    /// 廢止許可證
    /// </summary>
    public string? 處理情形_廢止許可證 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? 承辦備註說明 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第十五條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十五條 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十一條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十一條 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十二條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十二條 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十二條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十二條第一項 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十二條第二項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十二條第二項 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十八條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十八條第一項 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第二十八條第二項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第二十八條第二項 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第八條第一項
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第八條第一項 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第十三條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十三條 { get; set; }

    /// <summary>
    /// 食品安全衛生管理法第十一條
    /// </summary>
    public string? 違反法條_食品安全衛生管理法第十一條 { get; set; }

    /// <summary>
    /// 健康食品管理法第六條
    /// </summary>
    public string? 違反法條_健康食品管理法第六條 { get; set; }

    /// <summary>
    /// 健康食品管理法第十條
    /// </summary>
    public string? 違反法條_健康食品管理法第十條 { get; set; }

    /// <summary>
    /// 健康食品管理法第十一條
    /// </summary>
    public string? 違反法條_健康食品管理法第十一條 { get; set; }

    /// <summary>
    /// 健康食品管理法第十二條
    /// </summary>
    public string? 違反法條_健康食品管理法第十二條 { get; set; }

    /// <summary>
    /// 廢止登錄
    /// </summary>
    public string? 處理情形_廢止登錄 { get; set; }

    /// <summary>
    /// 移送法辦
    /// </summary>
    public string? 處理情形_移送法辦 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public DateOnly? 建立日期 { get; set; }

    public string? 處理情形_行政處分 { get; set; }
}
