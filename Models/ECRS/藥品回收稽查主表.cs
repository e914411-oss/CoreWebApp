using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥品回收稽查主表
{
    public int 藥品回收稽查編號 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string? 查核結果_數量是否相符 { get; set; }

    public string? 查核結果_是否完成回收 { get; set; }

    public string? 查核結果_是否已進行銷毀 { get; set; }

    public string? 違反法條_其他法條 { get; set; }

    public string? 違反法條_其他法條說明 { get; set; }

    public string? 不符情形_藥局不存在 { get; set; }

    public string? 不符情形_藥局已停歇業 { get; set; }

    public string? 不符情形_藥品流向不符 { get; set; }

    public string? 不符情形_其他 { get; set; }

    public string? 不符情形_其他說明 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_是否有沒入數量 { get; set; }

    public int? 處理情形_沒入數量 { get; set; }

    public string? 處理情形_其他 { get; set; }

    public string? 處理情形_其他說明 { get; set; }

    public string? 移外縣市_發送文號 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市編號 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 備註說明 { get; set; }

    public int? 專案名稱 { get; set; }

    public int? 專案明細 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 衛生局介接編號 { get; set; }

    public string? 衛生局介接上一次稽查編號 { get; set; }

    public string? 衛生局介接初查編號 { get; set; }

    public string? 違反法條_藥事法第16條第2項 { get; set; }

    public string? 違反法條_藥事法第21條第1項第2款 { get; set; }

    public string? 違反法條_藥事法第57條第2項 { get; set; }

    public string? 備註說明2 { get; set; }

    public string? 藥品數量不符情形 { get; set; }

    public string? 回收不符情形 { get; set; }
}
