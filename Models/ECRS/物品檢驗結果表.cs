using System;
using System.Collections.Generic;

namespace CoreWebApp.Models.ECRS;

public partial class 物品檢驗結果表
{
    public int 物品檢驗編號 { get; set; }

    public int 物品稽查編號 { get; set; }

    /// <summary>
    /// 抽驗檢驗-物品名稱
    /// </summary>
    public string? 物品名稱 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢查件數
    /// </summary>
    public string? 檢查件數 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢驗主類別
    /// </summary>
    public string? LIMS_主類編號 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢驗次類別
    /// </summary>
    public string? LIMS_次類編號 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢驗細類別
    /// </summary>
    public string? LIMS_細類編號 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢驗值
    /// </summary>
    public string? 檢驗結果值 { get; set; }

    /// <summary>
    /// 抽驗檢驗-檢驗結果
    /// </summary>
    public string? 檢驗結果 { get; set; }

    /// <summary>
    /// 抽驗檢驗-法規判定說明
    /// </summary>
    public string? 檢驗系統結果判定 { get; set; }

    public string? 判斷LIMS系統是否接入 { get; set; }

    public string? 批號 { get; set; }

    public string? 衛生局主鍵 { get; set; }

    public DateTime? 異動日期 { get; set; }

    public string? 異動人員 { get; set; }

    public string? 畫面物件資料綜合列表 { get; set; }

    public string? 檢驗方法編號 { get; set; }

    public string? 檢驗方法名稱 { get; set; }

    public int 類別 { get; set; }

    public string? 傳送至檢驗系統 { get; set; }

    public DateOnly? 傳送日期 { get; set; }

    public string? 傳送至代施機構 { get; set; }

    public string? 檢驗系統介接服務 { get; set; }

    public string? 建立文件時間 { get; set; }

    public string? 執行日期 { get; set; }

    public string? 執行次數 { get; set; }

    public string? 有效日期 { get; set; }

    public string? 填入值單位 { get; set; }

    public string? 檢驗系統檢驗項目代碼 { get; set; }

    public string? 檢驗系統檢驗成分代碼 { get; set; }

    public string? 檢驗系統檢驗結果 { get; set; }

    public string? 檢驗系統檢驗值 { get; set; }

    public string? 檢驗系統檢驗值的單位 { get; set; }

    public string? 檢驗系統案號 { get; set; }

    public string? 檢驗系統發文字號 { get; set; }

    public string? 檢驗系統檢體編號 { get; set; }

    public string? 代施機構檢驗最小值 { get; set; }

    public DateTime? 代施機構匯入日期 { get; set; }

    public string? 代施機構代號 { get; set; }

    public int? 送驗_申請單位代碼 { get; set; }

    public int? 送驗_採樣單位代碼 { get; set; }

    public string? LIMS系統_檢驗單位 { get; set; }

    public string? LIMS系統_檢體編號 { get; set; }

    public DateOnly? 檢驗結果報告日期 { get; set; }

    public DateTime? 建立日期 { get; set; }

    public DateTime? 檢驗單位收樣日期 { get; set; }

    public int? 檢驗方式_代碼 { get; set; }

    public string? 檢驗方式_內容 { get; set; }

    public string? 檢驗衛生局_縣市 { get; set; }

    public DateTime? LIMS檢驗結果回傳日期 { get; set; }
}
