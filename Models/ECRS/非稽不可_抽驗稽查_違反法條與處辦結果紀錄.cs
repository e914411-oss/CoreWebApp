using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 非稽不可_抽驗稽查_違反法條與處辦結果紀錄
{
    public int 抽驗違規項目編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    public DateOnly? 違反法條_處理限期改善日期 { get; set; }

    public string? 抽驗稽查_限期改善日期 { get; set; }

    public string? 抽驗稽查_飭其收回重製 { get; set; }

    public string? 抽驗稽查_禁止出售或沒收 { get; set; }

    public string? 抽驗稽查_廢棄重量_公斤_ { get; set; }

    public string? 抽驗稽查_處理罰款金額 { get; set; }

    public string? 抽驗稽查_停業 { get; set; }

    public string? 抽驗稽查_移送法院 { get; set; }

    public string? 抽驗稽查_移外縣市名稱 { get; set; }

    public string? 抽驗稽查_違規情節描述 { get; set; }

    public string? 抽驗稽查_處理情形 { get; set; }

    public string? 抽驗稽查_備註 { get; set; }

    public string? 抽驗稽查_違反法條 { get; set; }

    public string? 抽驗稽查_限期改善 { get; set; }

    public string? 抽驗稽查_移外縣市 { get; set; }

    public string? 抽驗稽查_移外縣市函送文號 { get; set; }

    public string? 抽驗稽查_移外縣市函送日期 { get; set; }

    public string? 抽驗稽查_移外縣市市招名稱 { get; set; }

    public string? 抽驗稽查_移外縣市負責人_ { get; set; }

    public string? 抽驗稽查_移外縣市業者地址 { get; set; }

    public string? 抽驗稽查_移外縣市移外原因 { get; set; }

    public string? 案件狀態 { get; set; }

    public string? 案件負責人 { get; set; }

    public string? 稽查員 { get; set; }

    public string? 承辦員 { get; set; }

    public string? 審查員 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 結案註記 { get; set; }

    public DateTime? 介面異動時間 { get; set; }

    public string? 介面異動者 { get; set; }

    public int? 複查編號 { get; set; }

    public int? 複查次數 { get; set; }

    public int? 稽查編號 { get; set; }

    public string? 抽驗稽查_其他法律 { get; set; }

    public string? 複驗合格 { get; set; }

    public string? 複驗合格_日期_ { get; set; }

    public string? 抽驗稽查_移其他單位辦理 { get; set; }

    public DateOnly? 登打日期 { get; set; }

    public string? 移外註記 { get; set; }
}
