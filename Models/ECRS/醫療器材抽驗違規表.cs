using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 醫療器材抽驗違規表
{
    /// <summary>
    /// 抽驗違規項目序號
    /// </summary>
    public int 主鍵 { get; set; }

    /// <summary>
    /// 醫療器材稽查序號
    /// </summary>
    public int? 醫療器材稽查明細表主鍵 { get; set; }

    /// <summary>
    /// 處分情形-行政處分
    /// </summary>
    public string? 處分情形_行政處分 { get; set; }

    /// <summary>
    /// 處分情形-移送法辦
    /// </summary>
    public string? 處分情形_移送法辦 { get; set; }

    /// <summary>
    /// 處分情形-移外縣市衛生局
    /// </summary>
    public string? 處分情形_移外縣市衛生局 { get; set; }

    /// <summary>
    /// 處分情形-行政輔導
    /// </summary>
    public string? 處分情形_行政輔導 { get; set; }

    /// <summary>
    /// 處分情形-移其他主管機關
    /// </summary>
    public string? 處分情形_移其他主管機關 { get; set; }

    /// <summary>
    /// 處分情形-移其他主管機關名稱
    /// </summary>
    public string? 處分情形_移其他主管機關名稱 { get; set; }

    /// <summary>
    /// 處分情形-產品回收
    /// </summary>
    public string? 處分情形_產品回收 { get; set; }

    /// <summary>
    /// 處分情形-回收期限
    /// </summary>
    public DateOnly? 處分情形_回收期限 { get; set; }

    /// <summary>
    /// 處分情形-回收數量
    /// </summary>
    public int? 處分情形_回收數量 { get; set; }

    /// <summary>
    /// 處分情形-其他
    /// </summary>
    public string? 處分情形_其他 { get; set; }

    /// <summary>
    /// 處分情形-其他處分
    /// </summary>
    public string? 處分情形_其他處分 { get; set; }

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

    public string? 移送法辦_對象 { get; set; }

    public string? 移送法辦_代表人 { get; set; }

    public string? 移送法辦_縣市 { get; set; }

    public string? 移送法辦_鄉鎮 { get; set; }

    public string? 移送法辦_地址 { get; set; }

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
    public string? 移外縣市主鍵 { get; set; }

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
    public string? 異動人員主鍵 { get; set; }

    public string? 是否已移出 { get; set; }

    public string? 衛生局主鍵 { get; set; }
}
