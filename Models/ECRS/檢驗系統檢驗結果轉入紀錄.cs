using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 檢驗系統檢驗結果轉入紀錄
{
    /// <summary>
    /// 系統識別碼
    /// </summary>
    public int 系統編號 { get; set; }

    public int 檢驗案號 { get; set; }

    public int 檢體編號 { get; set; }

    public int? PMDS檢驗項目編號 { get; set; }

    public string? 檢驗系統_檢驗成分編號 { get; set; }

    public string? 檢驗系統_檢驗成分名稱 { get; set; }

    public string? LIMS_主類編號 { get; set; }

    public string? LIMS_次類編號 { get; set; }

    public string? LIMS_細類編號 { get; set; }

    /// <summary>
    /// 檢驗結果
    /// </summary>
    public string? 檢驗系統檢驗結果 { get; set; }

    /// <summary>
    /// 檢驗值
    /// </summary>
    public string? 檢驗系統檢驗值 { get; set; }

    /// <summary>
    /// 檢驗值單位
    /// </summary>
    public string? 檢驗系統檢驗值單位 { get; set; }

    /// <summary>
    /// 檢驗結果判定
    /// </summary>
    public string? 檢驗系統結果判定 { get; set; }

    public string? 轉換成LIMS檢驗結果 { get; set; }

    public string? 轉換成LIMS檢驗值 { get; set; }

    public DateTime 建立日期 { get; set; }

    public string 建立人員 { get; set; } = null!;

    public DateTime 更新日期 { get; set; }

    public string 更新人員 { get; set; } = null!;

    public string? 案件類別 { get; set; }
}
