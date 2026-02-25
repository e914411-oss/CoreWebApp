using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 化粧品產品違規表
{
    public int 主鍵 { get; set; }

    public int? 化粧品稽查明細表主鍵 { get; set; }

    public string? 化粧品稽查類型 { get; set; }

    public string? 處分情形_限期改正 { get; set; }

    public DateOnly? 處分情形_限期改正日期 { get; set; }

    public string? 處分情形_行政處分 { get; set; }

    public string? 處分情形_停業 { get; set; }

    public DateOnly? 處分情形_停業期限 { get; set; }

    public string? 處分情形_歇業 { get; set; }

    public string? 處分情形_廢止登記 { get; set; }

    public string? 處分情形_移送法辦 { get; set; }

    public string? 處分情形_行政指導 { get; set; }

    public string? 處分情形_其他 { get; set; }

    public string? 處分情形_其他內容 { get; set; }

    public string? 處分情形_移外縣市 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public string? 移外縣市_縣市編號 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 移外縣市_是否移出 { get; set; }

    public DateOnly? 移送法辦_移送日期 { get; set; }

    public string? 移送法辦_移送文號 { get; set; }

    public string? 移送法辦_移送單位 { get; set; }

    public string? 移送法辦_移送對象 { get; set; }

    public string? 移送法辦_移送代表人 { get; set; }

    public string? 移送法辦_移送縣市 { get; set; }

    public string? 移送法辦_移送鄉鎮 { get; set; }

    public string? 移送法辦_移送地址 { get; set; }

    public string? 產品處置_命暫停或封存 { get; set; }

    public string? 產品處置_不得提供消費者 { get; set; }

    public string? 產品處置_英文名稱 { get; set; }

    public string? 產品處置_回收 { get; set; }

    public string? 產品處置_回收數量 { get; set; }

    public string? 產品處置_沒入銷毀 { get; set; }

    public string? 產品處置_銷毀數量 { get; set; }

    public string? 產品處置_退運 { get; set; }

    public string? 產品處置_退運數量 { get; set; }

    public string? 產品處置_其他 { get; set; }

    public string? 產品處置_其他說明 { get; set; }

    public string? 不良事件通報案件編號 { get; set; }

    public string? 備註說明 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }
}
