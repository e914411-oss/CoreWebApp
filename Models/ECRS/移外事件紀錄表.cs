using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 移外事件紀錄表
{
    public int 移外事件主鍵 { get; set; }

    public string? 來源事件種類 { get; set; }

    public int 來源事件代碼 { get; set; }

    public int? 由移外事件轉出 { get; set; }

    public string? 函送文號 { get; set; }

    public string? 函送日期 { get; set; }

    public string? 移出縣市 { get; set; }

    public string? 移入縣市 { get; set; }

    public string? 市招名稱 { get; set; }

    public string? 業者地址 { get; set; }

    public string? 負責人 { get; set; }

    public string? 物品名稱 { get; set; }

    public string? 移外原因 { get; set; }

    public string? 處理方式 { get; set; }

    public string? 違反法條 { get; set; }

    public string? 處理情形 { get; set; }

    public string? 罰鍰金額 { get; set; }

    public string? 函送文號_新 { get; set; }

    public string? 函送日期_新 { get; set; }

    public string? 移入縣市_新 { get; set; }

    public string? 市招名稱_新 { get; set; }

    public string? 業者地址_新 { get; set; }

    public string? 負責人_新 { get; set; }

    public string? 移外原因_新 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員 { get; set; }

    public string? 稽查人員主鍵 { get; set; }

    public string? 承辦人員主鍵 { get; set; }

    public string? 審查人員主鍵 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 衛生局稽查系統主鍵 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public DateTime? 稽查日期 { get; set; }

    public string? 移其他機關 { get; set; }

    public string? 查無違規情形 { get; set; }

    public string? 移出狀態 { get; set; }

    public string? 退回原因 { get; set; }

    public string? 是否為初次移外 { get; set; }

    public string? 縣市 { get; set; }

    public string? 是否行政處分 { get; set; }

    public int? 移出業者編號 { get; set; }

    public int? 移入業者編號 { get; set; }

    public string? 移出市招名稱 { get; set; }

    public string? 移出業者地址 { get; set; }

    public string? 專案名稱 { get; set; }

    public DateTime? 移出日期 { get; set; }
}
