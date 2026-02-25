using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 通路藥品回收稽查結果_ForQM
{
    public int? QMS藥品回收主檔編號 { get; set; }

    public int 通路藥品回收稽查系統編號 { get; set; }

    public string QMS縣市名稱 { get; set; } = null!;

    public string? PMDS縣市名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 數量是否相符 { get; set; }

    public string? 藥品數量不符情形 { get; set; }

    public string? 是否完成回收 { get; set; }

    public string? 回收不符情形 { get; set; }

    public string? 不符情形_藥局_房_不存在 { get; set; }

    public string? 不符情形_藥局_房_已停歇業 { get; set; }

    public string? 不符情形_藥品流向不符 { get; set; }

    public string? 不符情形_其他 { get; set; }

    public string? 不符情形_其他說明 { get; set; }

    public string? 處理情形_行政處分 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 處理情形_是否有沒入數量 { get; set; }

    public int? 處理情形_沒入數量 { get; set; }

    public string? 處理情形_其他 { get; set; }

    public string? 處理情形_其他說明 { get; set; }

    public string? 違反法條_藥事法第16條第2項 { get; set; }

    public string? 違反法條_藥事法第21條第1項第2款 { get; set; }

    public string? 違反法條_藥事法第57條第2項 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public int? 稽查事件編號 { get; set; }

    public string PMDS縣市代碼 { get; set; } = null!;

    public int QMS縣市代碼 { get; set; }
}
