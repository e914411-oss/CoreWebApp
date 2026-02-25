using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品標示違規表
{
    public int 主鍵 { get; set; }

    public int? 化粧品稽查明細表主鍵 { get; set; }

    public string? 處分情形_行政處分 { get; set; }

    public string? 處分情形_移送法辦 { get; set; }

    public string? 處分情形_限期改善 { get; set; }

    public DateOnly? 處分情形_限期改善日期 { get; set; }

    public string? 處分情形_沒入銷毀 { get; set; }

    public string? 處分情形_退運 { get; set; }

    public string? 處分情形_移外縣市衛生局 { get; set; }

    public string? 處分情形_行政輔導 { get; set; }

    /// <summary>
    /// 處分情形-移其他主管機關
    /// </summary>
    public string? 處分情形_移其他主管機關 { get; set; }

    /// <summary>
    /// 處分情形-回收數量
    /// </summary>
    public int? 處分情形_回收數量 { get; set; }

    /// <summary>
    /// 處分情形-其他
    /// </summary>
    public string? 處分情形_其他 { get; set; }

    /// <summary>
    /// 不良事件通報案件編號
    /// </summary>
    public string? 不良事件通報案件編號 { get; set; }

    /// <summary>
    /// 移送法辦_移送日期
    /// </summary>
    public DateOnly? 移送法辦_移送日期 { get; set; }

    /// <summary>
    /// 移送法辦_移送文號
    /// </summary>
    public string? 移送法辦_移送文號 { get; set; }

    /// <summary>
    /// 移送法辦_移送單位
    /// </summary>
    public string? 移送法辦_移送單位 { get; set; }

    public string? 移送對象 { get; set; }

    public string? 移送代表人 { get; set; }

    public string? 移送地址_縣市 { get; set; }

    public string? 移送地址_鄉鎮 { get; set; }

    public string? 移送地址_地址 { get; set; }

    /// <summary>
    /// 移外縣市-函送日期
    /// </summary>
    public DateOnly? 移外縣市_函送日期 { get; set; }

    /// <summary>
    /// 移外縣市-函送文號
    /// </summary>
    public string? 移外縣市_函送文號 { get; set; }

    /// <summary>
    /// 移外縣市-移外縣市
    /// </summary>
    public string? 移外縣市_移外縣市 { get; set; }

    /// <summary>
    /// 移外縣市-市招名稱
    /// </summary>
    public string? 移外縣市_市招名稱 { get; set; }

    /// <summary>
    /// 移外縣市-負責人
    /// </summary>
    public string? 移外縣市_負責人 { get; set; }

    /// <summary>
    /// 移外縣市-業者地址
    /// </summary>
    public string? 移外縣市_業者地址 { get; set; }

    /// <summary>
    /// 移外縣市-移外原因
    /// </summary>
    public string? 移外縣市_移外原因 { get; set; }

    /// <summary>
    /// 備註說明
    /// </summary>
    public string? 備註說明 { get; set; }

    /// <summary>
    /// 新增時間
    /// </summary>
    public DateTime? 建立時間 { get; set; }

    /// <summary>
    /// 新增人員
    /// </summary>
    public string? 建立人員主鍵 { get; set; }

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

    public string? 衛生局主鍵 { get; set; }

    public string? 是否移出 { get; set; }
}
