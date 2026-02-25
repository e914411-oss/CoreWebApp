using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 瘦身美容業稽查主表
{
    /// <summary>
    /// 瘦身美容業稽查主檔ID
    /// </summary>
    public int 瘦身美容業稽查主表主鍵 { get; set; }

    /// <summary>
    /// 稽查序號
    /// </summary>
    public int? 稽查事件主鍵 { get; set; }

    /// <summary>
    /// 稽查日期
    /// </summary>
    public DateOnly? 稽查日期 { get; set; }

    /// <summary>
    /// 稽查結果
    /// </summary>
    public string? 稽查結果 { get; set; }

    /// <summary>
    /// 稽查結果-限期改善日期
    /// </summary>
    public DateOnly? 稽查結果_限期改善日期 { get; set; }

    public string? 有無商業登記 { get; set; }

    public string? 瘦身美容定型化契約 { get; set; }

    public string? 瘦身美容定型化契約_是否訂定 { get; set; }

    public string? 瘦身美容商品服務禮券定型化契約 { get; set; }

    public string? 瘦身美容商品服務禮券定型化契約_是否訂定 { get; set; }

    /// <summary>
    /// 營業項目-體型、重量之控制、調整
    /// </summary>
    public string? 營業項目_調整 { get; set; }

    /// <summary>
    /// 營業項目-肌膚保養
    /// </summary>
    public string? 營業項目_肌膚保養 { get; set; }

    /// <summary>
    /// 營業項目-身體油壓
    /// </summary>
    public string? 營業項目_身體油壓 { get; set; }

    /// <summary>
    /// 營業項目-臉部美容、化粧
    /// </summary>
    public string? 營業項目_臉部美容化妝 { get; set; }

    /// <summary>
    /// 營業項目-脫毛
    /// </summary>
    public string? 營業項目_脫毛 { get; set; }

    /// <summary>
    /// 營業項目-美容諮詢及其相關商品之販賣
    /// </summary>
    public string? 營業項目_美容諮詢及其相關商品之販賣 { get; set; }

    /// <summary>
    /// 營業項目-其他
    /// </summary>
    public string? 營業項目_其他 { get; set; }

    /// <summary>
    /// 營業項目-其他說明
    /// </summary>
    public string? 營業項目_其他說明 { get; set; }

    /// <summary>
    /// 工作記錄_現場稽查說明
    /// </summary>
    public string? 工作記錄_現場稽查說明 { get; set; }

    /// <summary>
    /// 處分情形-停業
    /// </summary>
    public string? 處分情形_停業 { get; set; }

    /// <summary>
    /// 處分情形-移送法院
    /// </summary>
    public string? 處分情形_移送法院 { get; set; }

    /// <summary>
    /// 處分情形-行政處分
    /// </summary>
    public string? 處分情形_行政處分 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string? 備註說明 { get; set; }

    /// <summary>
    /// 前一次稽查事件編號
    /// </summary>
    public int? 前一次稽查事件編號 { get; set; }

    /// <summary>
    /// 稽查負責人
    /// </summary>
    public string? 作業負責人員主鍵 { get; set; }

    /// <summary>
    /// 稽查人員ID
    /// </summary>
    public string? 稽查人員主鍵 { get; set; }

    /// <summary>
    /// 承辦人員ID
    /// </summary>
    public string? 承辦人員主鍵 { get; set; }

    /// <summary>
    /// 審查人員ID
    /// </summary>
    public string? 審查人員 { get; set; }

    /// <summary>
    /// 流程階段
    /// </summary>
    public string? 作業階段 { get; set; }

    /// <summary>
    /// 結案狀態
    /// </summary>
    public string? 結案狀態 { get; set; }

    /// <summary>
    /// 結案日期
    /// </summary>
    public DateOnly? 結案日期 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員 { get; set; }

    /// <summary>
    /// 異動時間
    /// </summary>
    public DateTime? 異動時間 { get; set; }

    /// <summary>
    /// 異動人員
    /// </summary>
    public string? 異動人員 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 前次衛生局主鍵 { get; set; }

    public string? 第一次稽查衛生局稽查系統主鍵 { get; set; }
}
