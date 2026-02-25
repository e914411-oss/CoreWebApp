using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 紀錄_物品抽驗違規表
{
    public int 物品抽驗違規紀錄編號 { get; set; }

    public int? 已完成物品稽查編號 { get; set; }

    /// <summary>
    /// 抽驗違規項目序號
    /// </summary>
    public int? 物品抽驗編號 { get; set; }

    /// <summary>
    /// 資料界接外部Key
    /// </summary>
    public string? FMS介接編號 { get; set; }

    /// <summary>
    /// 物品稽查序號
    /// </summary>
    public int? 物品稽查編號 { get; set; }

    /// <summary>
    /// 違反法條-處理限期改善日期
    /// </summary>
    public DateOnly? 處理情形_限期改善日期 { get; set; }

    /// <summary>
    /// 違反法條-處理限期改善日期民國年月日
    /// </summary>
    public string? 處理情形_國曆限期改善日期 { get; set; }

    /// <summary>
    /// 違反法條-處理飭其收回重製（y/n）
    /// </summary>
    public string? 處理情形_飭其收回重製 { get; set; }

    /// <summary>
    /// 違反法條-處理禁止出售或沒收（y/n）
    /// </summary>
    public string? 處理情形_禁止出售或沒收 { get; set; }

    /// <summary>
    /// 違反法條-處理廢棄重量(公斤)
    /// </summary>
    public string? 處理情形_廢棄重量_公斤 { get; set; }

    /// <summary>
    /// 違反法條-處理罰款金額
    /// </summary>
    public string? 處理情形_罰款金額 { get; set; }

    /// <summary>
    /// 違反法條-處理停業（y/n）
    /// </summary>
    public string? 處理情形_停業 { get; set; }

    /// <summary>
    /// 違反法條-處理移送法院（y/n）
    /// </summary>
    public string? 處理情形_移送法院 { get; set; }

    /// <summary>
    /// 移外縣市(City_ID)
    /// </summary>
    public string? 移外縣市編號 { get; set; }

    /// <summary>
    /// 違規情節描述
    /// </summary>
    public string? 違規情節描述 { get; set; }

    /// <summary>
    /// 處理情形
    /// </summary>
    public string? FMS處理情形 { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? FMS備註 { get; set; }

    public string? 違反法條 { get; set; }

    public string? 處理情形_限期改善 { get; set; }

    public string? 處理情形_移外縣市 { get; set; }

    public string? 移外縣市_發送函號 { get; set; }

    public string? 移外縣市_函送日期 { get; set; }

    public string? 移外縣市_市招名稱 { get; set; }

    public string? 移外縣市_負責人 { get; set; }

    public string? 移外縣市_業者地址 { get; set; }

    public string? 移外縣市_移外原因 { get; set; }

    public string? 作業階段 { get; set; }

    public string? 作業負責人員 { get; set; }

    public string? 稽查人員 { get; set; }

    public string? 承辦人員 { get; set; }

    public string? 審查人員 { get; set; }

    public string? 結案日期 { get; set; }

    public string? 結案狀態 { get; set; }

    public DateTime? 異動時間 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public int? 前一次稽查編號 { get; set; }

    public int? 複查次數 { get; set; }

    public int? 最初稽查編號 { get; set; }

    public string? 上一次稽查衛生局主鍵 { get; set; }

    public string? 第一次稽查衛生局主鍵 { get; set; }

    public string? 違反法條_其他法律說明 { get; set; }

    public string? 處理情形_複驗合格 { get; set; }

    public string? 處理情形_國曆複驗合格日期 { get; set; }

    public string? 處理情形_移其他單位辦理 { get; set; }
}
