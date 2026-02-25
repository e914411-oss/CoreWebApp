using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒供應商_舊
{
    /// <summary>
    /// Poisoned_Factory
    /// </summary>
    public int 食品中毒供應商_主鍵 { get; set; }

    /// <summary>
    /// 中毒供應商名稱
    /// </summary>
    public string? 食品中毒供應商_名稱 { get; set; }

    /// <summary>
    /// 負責人
    /// </summary>
    public string? 負責人 { get; set; }

    /// <summary>
    /// 負責人身分證號
    /// </summary>
    public string? 負責人身分證號 { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string? 地址 { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? 電話 { get; set; }

    /// <summary>
    /// 分機
    /// </summary>
    public string? 分機 { get; set; }

    public string? 供應商之類別 { get; set; }

    /// <summary>
    /// 統一編號
    /// </summary>
    public string? 供應商編號 { get; set; }

    /// <summary>
    /// 肇事場所之處置
    /// </summary>
    public string? 供應商處置 { get; set; }

    /// <summary>
    /// 講習日期
    /// </summary>
    public DateTime? 會議日期 { get; set; }

    /// <summary>
    /// 最近稽查日期
    /// </summary>
    public DateTime? 稽查日期 { get; set; }

    /// <summary>
    /// 烹調人員
    /// </summary>
    public int? 廚師編號 { get; set; }

    /// <summary>
    /// 具中餐技術士
    /// </summary>
    public int? 技術執照編號 { get; set; }

    /// <summary>
    /// 具中餐技術士
    /// </summary>
    public int? 會議編號 { get; set; }

    /// <summary>
    /// 食品製造所調查-給水
    /// </summary>
    public string? 勘查_水源 { get; set; }

    /// <summary>
    /// 食品製造所調查-廚房
    /// </summary>
    public string? 勘查_廚房 { get; set; }

    /// <summary>
    /// 食品製造所調查-廁所
    /// </summary>
    public string? 勘查_廁所 { get; set; }

    /// <summary>
    /// 食品製造所調查-排水系統
    /// </summary>
    public string? 勘查_排水系統 { get; set; }

    /// <summary>
    /// 食品製造所調查-蒼蠅、蟑螂、鼠
    /// </summary>
    public string? 勘查_害蟲 { get; set; }

    /// <summary>
    /// 食品製造所調查-從業人員健康情形
    /// </summary>
    public string? 勘查_健康狀況 { get; set; }
}
