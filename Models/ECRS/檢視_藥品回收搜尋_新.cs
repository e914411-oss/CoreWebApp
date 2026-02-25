using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢視_藥品回收搜尋_新
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

    public string? Status { get; set; }

    public string? 作業階段 { get; set; }

    public string? 結案狀態 { get; set; }

    public string? Inspector { get; set; }

    public string? Undertaker { get; set; }

    public string? Reviewer { get; set; }

    public string 稽查人員 { get; set; } = null!;

    public string 承辦人員 { get; set; } = null!;

    public string 審查人員 { get; set; } = null!;

    public string? 結案日期 { get; set; }

    public DateOnly? 發文日期 { get; set; }

    public string? 發文字號 { get; set; }

    public string? 回收藥品品名 { get; set; }

    public string? 回收藥品之許可證字號 { get; set; }

    public string? 回收批號 { get; set; }

    public string? 許可證持有者 { get; set; }

    public string? 製造廠 { get; set; }

    public string? 回收原因 { get; set; }

    public string? 受貨者名稱 { get; set; }

    public string? 地址_縣市 { get; set; }

    public string? 地址_區域 { get; set; }

    public string? 地址_地址 { get; set; }

    public DateOnly? 出廠日期 { get; set; }

    public string? 批號或型號 { get; set; }

    public int? 銷售數量 { get; set; }

    public int? 使用者通報數量_合格 { get; set; }

    public int? 使用者通報數量_不合格 { get; set; }

    public DateTime? CHKDATE { get; set; }

    public string? CHKDATE_ROC { get; set; }

    public string? Signboard_Name { get; set; }

    public string? Business_City_ID { get; set; }

    public string? Business_County_ID { get; set; }

    public string? 發文字號_號 { get; set; }

    public string? 受處分人 { get; set; }

    public string? 違反法規_舊 { get; set; }

    public int? 罰緩 { get; set; }

    public string 藥品數量不符情形 { get; set; } = null!;

    public string 回收不符情形 { get; set; } = null!;

    public string? 衛生局介接編號 { get; set; }

    public string? 會同單位_檢 { get; set; }

    public string? 會同單位_警 { get; set; }

    public string? 會同單位_調 { get; set; }

    public string? 會同單位_食藥署 { get; set; }

    public string? 會同單位_其它 { get; set; }

    public string? 會同單位_其它單位名稱 { get; set; }
}
