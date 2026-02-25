using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 食品中毒食品供應商明細表
{
    public int 食品中毒食品供應商明細表_主鍵 { get; set; }

    public string? FMS介接主鍵 { get; set; }

    public int? 食品中毒速報主表主鍵 { get; set; }

    public string? 供應商名稱 { get; set; }

    public string? 負責人 { get; set; }

    public string? 負責人身分證號 { get; set; }

    public string? 城市 { get; set; }

    public string? 地址 { get; set; }

    public string? 聯絡電話 { get; set; }

    public string? 分機 { get; set; }

    public string? 場所之類別 { get; set; }

    public string? 統一編號 { get; set; }

    public string? 肇事場所之處置 { get; set; }

    public string? 肇事場所之處置_其它 { get; set; }

    public string? 講習日期 { get; set; }

    public string? 最近稽查日期 { get; set; }

    public string? 烹調人員 { get; set; }

    public string? 具中餐技術士 { get; set; }

    public string? 參加食品衛生講習 { get; set; }

    public string? 給水 { get; set; }

    public string? 廚房 { get; set; }

    public string? 廁所 { get; set; }

    public string? 排水系統 { get; set; }

    public string? 蒼蠅蟑螂老鼠 { get; set; }

    public string? 從業人員健康情形 { get; set; }

    public string? 食品製造所調查 { get; set; }

    public DateTime? 更新時間 { get; set; }

    public string? 更新人員 { get; set; }
}
