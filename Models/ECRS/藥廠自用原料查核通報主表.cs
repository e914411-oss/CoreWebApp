using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 藥廠自用原料查核通報主表
{
    public int 主鍵 { get; set; }

    public int? 稽查序號 { get; set; }

    public string? 查核結果_報關文件相符 { get; set; }

    public string? 查核結果_資訊相符 { get; set; }

    public int? 查核結果_實際進口量 { get; set; }

    public DateTime? 查核結果_進口時間 { get; set; }

    public string? 查核結果_原料原廠批號 { get; set; }

    public int? 查核結果_入庫數量 { get; set; }

    public DateTime? 查核結果_入庫時間 { get; set; }

    public int? 查核結果_原料剩餘數量 { get; set; }

    public string? 查核結果_入庫量相符 { get; set; }

    public string? 查核結果_入庫時間是否合理 { get; set; }

    public string? 查核結果_是否提出解釋及切結書 { get; set; }

    public DateOnly? 查核結果_處分時間 { get; set; }

    public string? 查核結果_缺失說明 { get; set; }

    public string? 查核結果_其他說明 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public DateOnly? 處分情形_限期改善日期 { get; set; }

    public string? 處理情形_禁止出售 { get; set; }

    public string? 處理情形_其他 { get; set; }

    public string? 處理情形_其他說明 { get; set; }

    public string? 移外縣市_函送文號 { get; set; }

    public DateOnly? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市主鍵 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 備註說明 { get; set; }

    public int? 專案名稱主鍵 { get; set; }

    public int? 專案明細主鍵 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public DateTime? 建立時間 { get; set; }

    public string? 建立人員主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員主鍵 { get; set; }

    public int? 前一次稽查主鍵 { get; set; }

    public int? 複查筆數 { get; set; }

    public int? 最初稽查主鍵 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public string? 前次稽查衛生局稽查系統主鍵 { get; set; }

    public string? 第一次稽查衛生局稽查系統主鍵 { get; set; }

    public string? 違反藥事法第16條第2項 { get; set; }

    public string? 違反藥事法第46條第1項 { get; set; }

    public string? 違反藥事法第53條第1項 { get; set; }

    public string? 違反其它藥事法法條 { get; set; }

    public string? 備註說明2 { get; set; }

    public string? 違反其它藥事法法條_敘述 { get; set; }
}
