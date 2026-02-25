using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 回收後續處理情形稽查結果_化粧品_ForQM
{
    public int QMS化粧品回收主檔編號 { get; set; }

    public int 化粧品回收處理編號 { get; set; }

    public string QMS縣市名稱 { get; set; } = null!;

    public string? PMDS縣市名稱 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public DateOnly? 結案日期 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 是否與回收報告書所載數量相符 { get; set; }

    public string? 數量不符之理由 { get; set; }

    public DateOnly? 查核日期 { get; set; }

    public string? 衛生局聯絡窗口 { get; set; }

    public string? 衛生局聯絡電話 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public int 稽查事件編號 { get; set; }

    public string PMDS縣市代碼 { get; set; } = null!;

    public int QMS縣市代碼 { get; set; }
}
